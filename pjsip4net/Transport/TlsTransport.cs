using System;
using pjsip4net.Core;
using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Interfaces;

namespace pjsip4net.Transport
{
    internal class TlsTransport : VoIPTransport, ITlsTransport
    {
        public TlsTransport(ITransportApiProvider transportApiProvider)
            : base(transportApiProvider)
        {
            _transportType = TransportType.Tls;
        }

        public String CAListFile
        {
            get { return _config.TlsSetting.CAListFile; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.CAListFile = value;
            }
        }

        public String CertificateFile
        {
            get { return _config.TlsSetting.CertFile; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.CertFile = value;
            }
        }

        public String PrivateKeyFile
        {
            get { return _config.TlsSetting.PrivKeyFile; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.PrivKeyFile = value;
            }
        }

        public bool VerifyServer
        {
            get { return _config.TlsSetting.VerifyServer; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.VerifyServer = value;
            }
        }

        public bool VerifyClient
        {
            get { return _config.TlsSetting.VerifyClient; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.VerifyClient = value;
            }
        }

        public bool RequireClientCertificate
        {
            get { return _config.TlsSetting.RequireClientCert; }
            set
            {
                GuardDisposed();
                GuardNotInitializing();
                _config.TlsSetting.RequireClientCert = value;
            }
        }

        public override void BeginInit()
        {
            base.BeginInit();
            _config.Port = 5061;
        }
    }
}