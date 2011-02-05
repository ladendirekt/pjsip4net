using System;
using AutoMapper;
using pjsip4net.Core.Data;

namespace pjsip.Interop.Services
{
    public class TransportInfoConverter : ITypeConverter<pjsua_transport_info, TransportInfo>
    {
        #region Implementation of ITypeConverter<pjsua_transport_info,TransportInfo>

        public TransportInfo Convert(ResolutionContext context)
        {
            var x = (pjsua_transport_info) context.SourceValue;
            var rx = (TransportInfo) context.DestinationValue ?? new TransportInfo();
            rx.AddrLen = x.addr_len;
            rx.Flag = x.flag;
            rx.Id = x.id;
            rx.Info = x.info;
            //rx.Host = x.local_name.host;
            //rx.Port = x.local_name.port;
            rx.Type = x.type.ToTransportType();
            rx.TypeName = x.type_name;
            //rx.UsageCount = x.usage_count;
            return rx;
        }

        #endregion
    }
}