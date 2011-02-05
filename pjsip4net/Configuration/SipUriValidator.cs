using System;
using System.Configuration;
using pjsip4net.Core;
using pjsip4net.Core.Utils;

namespace pjsip4net.Configuration
{
    internal class SipUriValidator : ConfigurationValidatorBase
    {
        public override void Validate(object value)
        {
            try
            {
                Helper.GuardIsTrue(new SipUriParser(value.ToString()).IsValid);
            }
            catch (PjsipErrorException ex)
            {
                throw new ConfigurationErrorsException("Invalid sip uri", ex);
            }
        }

        public override bool CanValidate(Type type)
        {
            return type.Equals(typeof (string));
        }
    }

    internal class SipUriValidatorAttribute : ConfigurationValidatorAttribute
    {
        public override ConfigurationValidatorBase ValidatorInstance
        {
            get { return new SipUriValidator(); }
        }
    }
}