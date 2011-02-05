using System.Collections.Generic;
using System.Net;

namespace pjsip4net.Core.Data
{
    public class AccountConfig
    {
        private List<string> _proxy = new List<string>(8);
        private List<NetworkCredential> _cred_info = new List<NetworkCredential>(8);

        public bool IsDefault { get; set; }

        public object UserData { get; set; }
        public int Priority { get; set; }
        public string Id { get; set; }
        public string RegUri { get; set; }
        public bool IsPublishEnabled { get; set; }
        public string PidfTupleId { get; set; }
        public string ForceContact { get; set; }
        public string ContactParams { get; set; }
        public string ContactUriParams { get; set; }
        public bool Require100Rel { get; set; }
        public bool RequireTimer { get; set; }
        public uint RegTimeout { get; set; }
        public int TransportId { get; set; }
        public bool AllowContactRewrite { get; set; }
        public uint KaInterval { get; set; }
        public string KaData { get; set; }
        public SrtpRequirement UseSrtp { get; set; }
        public int SrtpSecureSignaling { get; set; }

        public List<string> Proxy
        {
            get { return _proxy; }
            set { _proxy = value; }
        }

        public List<NetworkCredential> Credentials
        {
            get { return _cred_info; }
            set { _cred_info = value; }
        }
    }
}