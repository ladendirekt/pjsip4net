using AutoMapper;

namespace pjsip.Interop.Services
{
    public class Pjsua2Pjsip4netProfile : Profile
    {
        protected override void Configure()
        {
            base.Configure();
            SourceMemberNamingConvention = new LowerUnderscoreNamingConvention();
            DestinationMemberNamingConvention = new PascalCaseNamingConvention();
        }

        public override string ProfileName
        {
            get
            {
                return "pjsua2pjsip4net";
            }
        }
    }
}