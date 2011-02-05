using System.Text;

namespace pjsip4net.Core.Utils
{
    public class SipUriBuilder
    {
        public const string SIPScheme = "sip:";
        private string _domain;
        private string _extension;
        private string _port;
        private TransportType? _transportType;

        public SipUriBuilder AppendExtension(string extension)
        {
            _extension = extension;
            return this;
        }

        public SipUriBuilder AppendDomain(string domain)
        {
            Helper.GuardNotNullStr(domain);

            _domain = domain;
            return this;
        }

        public SipUriBuilder AppendPort(string port)
        {
            _port = port;
            return this;
        }

        public SipUriBuilder AppendTransportSuffix(TransportType transportType)
        {
            _transportType = transportType;
            return this;
        }

        public void Clear()
        {
            _extension = null;
            _domain = null;
            _port = null;
            _transportType = null;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(SIPScheme);
            if (!string.IsNullOrEmpty(_extension))
                sb.Append(_extension).Append("@");
            sb.Append(_domain);
            if (!string.IsNullOrEmpty(_port))
                sb.Append(":").Append(_port);
            if (_transportType.HasValue)
                sb.Append(";transport=").Append(_transportType.ToString().ToUpperInvariant());

            return sb.ToString();
        }
    }
}