using System;
using pjsip4net.Core.Data;
using pjsip4net.Core.Interfaces.ApiProviders;

namespace pjsip4net.Testing
{
    public class BasicApiTestProvider : IBasicApiProvider
    {
        public UaConfig GetDefaultUaConfig()
        {
            return new UaConfig();
        }

        public LoggingConfig GetDefaultLoggingConfig()
        {
            return new LoggingConfig();
        }

        public void InitPjsua(UaConfig uaCfg, LoggingConfig logCfg, MediaConfig mediaCfg)
        {
        }

        public void CreatePjsua()
        {
        }

        public void Start()
        {
        }

        public void Destroy()
        {
        }

        public void Dump(bool detail)
        {
        }
    }
}