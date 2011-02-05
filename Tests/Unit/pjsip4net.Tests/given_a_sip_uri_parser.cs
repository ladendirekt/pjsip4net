using NUnit.Framework;
using pjsip4net.Core;
using pjsip4net.Core.Utils;

namespace pjsip4net.Tests
{
    /// <summary>
    /// Summary description for SipUriParserTests
    /// </summary>
    [TestFixture]
    public class given_a_sip_uri_parser
    {
        public given_a_sip_uri_parser()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        [Test]
        public void when_parse_called_with_valid_sip_uri_with_domain_as_IP__should_fill_valid_properties()
        {
            var sut = new SipUriParser("<sip:12.25.12.1>");

            Assert.AreEqual("12.25.12.1", sut.Domain);
            Assert.AreEqual("", sut.Extension);
            Assert.AreEqual("5060", sut.Port);
            Assert.AreEqual("", sut.Password);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_domain_as_dns__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:tempuri.org");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("", sut.Extension);
            Assert.AreEqual("5060", sut.Port);
            Assert.AreEqual("", sut.Password);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_alfabet_extension_and_domain_as_dns__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:test@tempuri.org");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("test", sut.Extension);
            Assert.AreEqual("5060", sut.Port);
            Assert.AreEqual("", sut.Password);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_alfabet_extension_and_domain_as_dns_and_port__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:test@tempuri.org:5080");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("test", sut.Extension);
            Assert.AreEqual("5080", sut.Port);
            Assert.AreEqual("", sut.Password);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_alfabet_extension_and_pwd_and_domain_as_dns_and_port__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:test:test@tempuri.org:5080");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("test", sut.Extension);
            Assert.AreEqual("5080", sut.Port);
            Assert.AreEqual("test", sut.Password);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_alfabet_extension_and_pwd_and_domain_as_dns_and_port_with_transport_header__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:test:test@tempuri.org:5080;transport=tcp");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("test", sut.Extension);
            Assert.AreEqual("5080", sut.Port);
            Assert.AreEqual("test", sut.Password);
            Assert.AreEqual(1, sut.Headers.Count);
            Assert.AreEqual(TransportType.Tcp, sut.Transport);
        }
        
        [Test]
        public void when_parse_called_with_valid_sip_uri_with_alfabet_domain_as_dns_with_transport_header__should_fill_valid_properties()
        {
            var sut = new SipUriParser("sip:tempuri.org;transport=tcp");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("", sut.Extension);
            Assert.AreEqual("5060", sut.Port);
            Assert.AreEqual("", sut.Password);
            Assert.AreEqual(1, sut.Headers.Count);
            Assert.AreEqual(TransportType.Tcp, sut.Transport);
        }
        
        [Ignore]
        public void Parse_ValidSipUriWithAlfabetDomainAsDnsWithTransportHeaderAndSomaOtherHeader_ValidPropertiesFilled()
        {
            var sut = new SipUriParser("sip:tempuri.org;transport=tcp;otherheader");

            Assert.AreEqual("tempuri.org", sut.Domain);
            Assert.AreEqual("", sut.Extension);
            Assert.AreEqual("5060", sut.Port);
            Assert.AreEqual("", sut.Password);
            Assert.AreEqual(2, sut.Headers.Count);
            Assert.AreEqual(TransportType.Tcp, sut.Transport);
        }

    }
}