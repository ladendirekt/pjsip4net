using AutoMapper;
using Moq;
using NUnit.Framework;
//using pjsip.Interop.Services;
using pjsip.Interop;
using pjsip.Interop.Services;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_mapper
    {
        private IFixture _fixture;
        private AutoMappingMapper _sut;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            var container = _fixture.Freeze<Mock<IContainer>>();
            _sut =
                _fixture.Build<AutoMappingMapper>().FromFactory(
                    () => new AutoMappingMapper(Mapper.Engine, container.Object)).CreateAnonymous();
        }

        [TearDown]
        public void Teardown()
        {
            _fixture = null;
            _sut = null;
            Mapper.Reset();
        }

        [Test]
        public void pjsua2pjsip4net_profile_mapping_should_be_valid()
        {
            Mapper.AssertConfigurationIsValid("pjsua2pjsip4net");
        }

        [Test]
        public void pjsip4net2pjsua_profile_mapping_should_be_valid()
        {
            Mapper.AssertConfigurationIsValid("pjsip4net2pjsua");
        }

        [Test]
        public void default_profile_mapping_should_be_valid()
        {
            Mapper.AssertConfigurationIsValid();
        }

        [Test]
        public void should_map_uaconfig()
        {
            var x = _sut.Map(new pjsua_config(), new UaConfig());
            Assert.That(x, Is.Not.Null);
        }
    }
    // ReSharper restore InconsistentNaming
}