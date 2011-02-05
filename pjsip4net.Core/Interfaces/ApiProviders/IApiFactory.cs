namespace pjsip4net.Core.Interfaces.ApiProviders
{
    public interface IApiFactory
    {
        IBasicApiProvider GetBasicApi();
        ITransportApiProvider GetTransportApi();
        IAccountApiProvider GetAccountApi();
        ICallApiProvider GetCallApi();
        IIMApiProvider GetImApi();
        IMediaApiProvider GetMediaApi();
    }
}