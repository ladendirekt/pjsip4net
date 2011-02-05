using System.Linq;
using AutoMapper;
using pjsip4net.Core.Data;

namespace pjsip.Interop.Services
{
    public class ConferencePortInfoConverter : ITypeConverter<pjsua_conf_port_info, ConferencePortInfo>
    {
        #region Implementation of ITypeConverter<pjsua_conf_port_info,ConferencePortInfo>

        public ConferencePortInfo Convert(ResolutionContext context)
        {
            var x = (pjsua_conf_port_info)context.SourceValue;
            var rx = (ConferencePortInfo)context.DestinationValue ?? new ConferencePortInfo();

            rx.BitsPerSample = x.bits_per_sample;
            rx.ChannelCount = x.channel_count;
            rx.ClockRate = x.clock_rate;
            rx.Listeners = x.listeners.ToList();
            rx.Name = x.name;
            rx.SamplesPerFrame = x.samples_per_frame;
            rx.SlotId = x.slot_id;

            return rx;
        }

        #endregion
    }
}