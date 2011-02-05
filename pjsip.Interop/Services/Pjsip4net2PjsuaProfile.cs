using AutoMapper;

namespace pjsip.Interop.Services
{
    public class Pjsip4net2PjsuaProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();
            SourceMemberNamingConvention = new PascalCaseNamingConvention();
            DestinationMemberNamingConvention = new LowerUnderscoreNamingConvention();
        }

        public override string ProfileName
        {
            get
            {
                return "pjsip4net2pjsua";
            }
        }
    }
}