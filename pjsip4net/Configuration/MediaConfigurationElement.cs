using System.Configuration;

namespace pjsip4net.Configuration
{
    public class MediaConfigurationElement : ConfigurationElement
    {
        private readonly ConfigurationProperty _captDevIdProp = new ConfigurationProperty("captureDeviceId",
                                                                                          typeof (int), -1,
                                                                                          null,
                                                                                          new IntegerValidator(-1, 255,
                                                                                                               false),
                                                                                          ConfigurationPropertyOptions.
                                                                                              None);

        private readonly ConfigurationProperty _playbDevIdProp = new ConfigurationProperty("playbackDeviceId",
                                                                                           typeof (int), -1,
                                                                                           null,
                                                                                           new IntegerValidator(-1, 255,
                                                                                                                false),
                                                                                           ConfigurationPropertyOptions.
                                                                                               None);

        private readonly ConfigurationPropertyCollection _properties;

        private readonly ConfigurationProperty _vadEnabled = new ConfigurationProperty("isVADEnabled", typeof (bool),
                                                                                       true);

        public MediaConfigurationElement()
        {
            _properties = new ConfigurationPropertyCollection
                              {
                                  _vadEnabled,
                                  _captDevIdProp,
                                  _playbDevIdProp
                              };
        }

        //private ConfigurationProperty _clockRateProp = new ConfigurationProperty("clockRate", typeof(uint), );

        [ConfigurationProperty("isVADEnabled", DefaultValue = true)]
        public bool IsVadEnabled
        {
            get { return (bool) base[_vadEnabled]; }
            set { base[_vadEnabled] = value; }
        }

        [ConfigurationProperty("captureDeviceId", DefaultValue = -1)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 255, MinValue = -1)]
        public int CaptureDeviceId
        {
            get { return (int) base[_captDevIdProp]; }
            set { base[_captDevIdProp] = value; }
        }

        [ConfigurationProperty("playbackDeviceId", DefaultValue = -1)]
        [IntegerValidator(ExcludeRange = false, MaxValue = 255, MinValue = -1)]
        public int PlaybackDeviceId
        {
            get { return (int) base[_playbDevIdProp]; }
            set { base[_playbDevIdProp] = value; }
        }

        protected override ConfigurationPropertyCollection Properties
        {
            get { return _properties; }
        }
    }
}