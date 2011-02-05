using pjsip4net.Core.Interfaces.ApiProviders;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Data
{
    public class CodecInfo : Initializable
    {
        private IMediaApiProvider _mediaApi;

        #region Properties

        public string CodecId { get; protected set; }

        private byte _priority;
        public byte Priority
        {
            get { return _priority; }
            set
            {
                Helper.GuardInRange<byte>(0, 255, value);
                _mediaApi.SetCodecPriority(CodecId, value);
                _priority = value;
            }
        }

        //public uint ClockRate
        //{
        //    get { return _param.info.clock_rate; }
        //}

        //public uint ChannelCount
        //{
        //    get { return _param.info.channel_cnt; }
        //}

        //public uint AvgBandwidthBPS
        //{
        //    get { return _param.info.avg_bps; }
        //}

        //public uint MaxBandwidthBPS
        //{
        //    get { return _param.info.max_bps; }
        //}

        //public ushort DecoderPTime
        //{
        //    get { return _param.info.frm_ptime; }
        //}

        //public ushort EncoderPTime
        //{
        //    get { return _param.info.enc_ptime == 0 ? _param.info.frm_ptime : _param.info.enc_ptime; }
        //}

        //public byte PCMBitsPerSample
        //{
        //    get { return _param.info.pcm_bits_per_sample; }
        //}

        //public byte PayloadType
        //{
        //    get { return _param.info.pt; }
        //}

        //public string Format
        //{
        //    get { return _param.info.fmt_id.ToString(); }
        //}

        //public byte FramesPerPacket
        //{
        //    get { return _param.setting.frm_per_pkt; }
        //    set
        //    {
        //        GuardNotInitializing();
        //        _param.setting.frm_per_pkt = value;
        //    }
        //}

        //public bool VAD
        //{
        //    get { return _param.setting.vad == 1; }
        //    set 
        //    {
        //        GuardNotInitializing();
        //        _param.setting.vad = value ? 1u : 0u;
        //    }
        //}

        //public bool ComfortNoiseGenerator
        //{
        //    get { return _param.setting.cng == 1; }
        //    set
        //    {
        //        GuardNotInitializing();
        //        _param.setting.cng = value ? 1u : 0u;
        //    }
        //}

        //public bool PerceptualEnhancement
        //{
        //    get { return _param.setting.penh == 1; }
        //    set
        //    {
        //        GuardNotInitializing();
        //        _param.setting.penh = value ? 1u : 0;
        //    }
        //}

        //public bool PacketLossConcealment
        //{
        //    get { return _param.setting.plc == 1; }
        //    set
        //    {
        //        GuardNotInitializing();
        //        _param.setting.plc = value ? 1u : 0u;
        //    }
        //}

        #endregion

        //private pjmedia_codec_param _param;

        public CodecInfo(IMediaApiProvider mediaApi)
        {
            Helper.GuardNotNull(mediaApi);
            _mediaApi = mediaApi;
            //pj_str_t name = info.codec_id;
            //pjmedia_codec_param tmp = new pjmedia_codec_param();
            /*Helper.GuardError(*/
            //PJSUA_DLL.Media.pjsua_codec_get_param(ref name, ref tmp)/*)*/;
            //_param = tmp;
        }

        public override void BeginInit()
        {
            _isInitializing = true;
        }

        public override void EndInit()
        {
            base.EndInit();

            Helper.GuardInRange(0u, 255u, _priority);
            _mediaApi.SetCodecPriority(CodecId, _priority);
        }
    }
}