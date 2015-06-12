using pjsip4net.Core.Configuration;
using pjsip.Interop;
using pjsip4net.Configuration;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using ObjectDumper;
using pjsip4net.Interfaces;
using Castle.Windsor;
using pjsip4net.Container.Castle;
using pjsip4net.Core.Data;
using Couchbase;

namespace MultiRinger
{
    class Program
    {
        private static readonly TraceSource _traceSource = new TraceSource("MultiRinger", SourceLevels.Error);
        private static readonly Cluster Cluster = new Cluster("couchbaseClients/couchbase");




        static void Main(string[] args)
        {


            _traceSource.TraceInformation("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");



            pjsip4net.Interfaces.ISipUserAgent ua = null;

            try
            {
                Console.WriteLine("begin");

                var pj = Configure.Pjsip4Net();
                Console.WriteLine("config");

                //pj.FromConfig();

                //pj.With((o) =>
                //{
                //    var t = o.Config.ThreadCount;
                //});

                //pj.With((o) => {
                //    o.Config.AutoAnswer = true;
                //    o.Config.AutoConference = false;
                //    o.Config.AutoRecord = false;
                //    //o.Config.Credentials
                //    //o.Config.DnsServers
                //    o.Config.ForceLooseRoute = false;
                //    o.Config.HangupForkedCall = false;
                //    o.Config.MaxCalls = 100;
                //    //o.Config.OutboundProxies = new List<string>() { "fffff" };
                //    //o.Config.Require100Rel = true;
                //    //o.Config.SecureSignalling = 0;
                //    //o.Config.StunDomain
                //    //o.Config.StunHost
                //    //o.Config.StunIgnoreFailure
                //    //o.Config.StunServers
                //    //o.Config.ThreadCount = 2;
                //    var tc = o.Config.ThreadCount;
                //    o.Config.UserAgent = "I'm RaulandBorg";
                //    //o.Config.UseSrtp = pjsip4net.Core.Data.SrtpRequirement.Optional;

                //    o.LoggingConfig.LogLevel = 100;
                //    o.LoggingConfig.LogMessages = true;
                //    o.LoggingConfig.TraceAndDebug = true;


                //    //o.MediaConfig.AudioFramePtime 
                //    //o.MediaConfig.

                //    //o.RegisterAccounts(new List<pjsip4net.Core.Data.AccountConfig>());
                //    var transportType = new pjsip4net.Core.Data.TransportConfig();
                //    transportType.BoundAddress = "0.0.0.0";
                //    transportType.Port = 5080;
                //    transportType.PublicAddress = "0.0.0.0";
                //    //transportType.TlsSetting.CAListFile
                //    var trspt = new pjsip4net.Core.Utils.Tuple<pjsip4net.Core.TransportType, pjsip4net.Core.Data.TransportConfig>
                //        (pjsip4net.Core.TransportType.Udp, transportType);
                //    o.RegisterTransport(trspt);


                //});

                //pj.WithSipTransport((o) => {

                //    return new pjsip4net.Core.Utils.Tuple<pjsip4net.Core.TransportType, pjsip4net.Core.Data.TransportConfig>();

                //});



                pj.FromConfig().With(o =>
                {
                    o.Config.ThreadCount = 5;

                    var transportType = new pjsip4net.Core.Data.TransportConfig();
                    transportType.BoundAddress = "0.0.0.0";
                    //transportType.Port = 5080;
                    transportType.PublicAddress = "0.0.0.0";
                    //transportType.TlsSetting.CAListFile
                    var trspt = new pjsip4net.Core.Utils.Tuple<pjsip4net.Core.TransportType, pjsip4net.Core.Data.TransportConfig>
                        (pjsip4net.Core.TransportType.Udp, transportType);
                    o.RegisterTransport(trspt);



                });

                var container = new WindsorContainer();
                var cfg = pj.With_CastleContainer(container);//plugs an existing DI-container



                //this isnt working for me now
                //var cmx = cfg.Container.Get<ICallManager>();




                ua = cfg.Build();
                Console.WriteLine("built");


                ua.Log += ua_Log;
                Console.WriteLine("starting.");



                ua.CallManager.CallRedirected += CallManager_CallRedirected;
                //get current calls
                //ua.CallManager.Calls
                ua.CallManager.CallStateChanged += CallManager_CallStateChanged;
                ua.CallManager.CallTransfer += CallManager_CallTransfer;
                //ua.CallManager.GetCallById()
                //ua.CallManager.HangupAll()
                ua.CallManager.IncomingCall += CallManager_IncomingCall;
                ua.CallManager.IncomingDtmfDigit += CallManager_IncomingDtmfDigit;




                ua.CallManager.MaxCalls = 100;
                ua.CallManager.Ring += CallManager_Ring;

                ua.Start();



                //register as who we are?
                IAccount account = ua.AccountManager.Register(new Func<IAccountBuilder, IAccount>(o =>
                {
                    return o.At("local-rb").WithExtension("BRC1").Register();
                }));



                //ua.ImManager



                MakeACall(ua.CallManager, cfg.Container, account, @"sip:externalparty@local-rb");
                //MakeACall(ua.CallManager, cfg.Container, @"sip:*80*@local-rb");
                //MakeACall(ua.CallManager, cfg.Container, @"sip:*300*@local-rb");

                //var ua = Configure.Pjsip4Net().With(x => x.Config.AutoAnswer = false).Build().Start();

                //Configure.Pjsip4Net().WithVersion_1_4().Build().Start();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                
                //we are going to eat these
                //throw;
            }
            Console.WriteLine("in process");

            Console.ReadLine();

            try
            {
                ua.Destroy();
                ua.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        private static void MakeACall(ICallManager callManager, pjsip4net.Core.Interfaces.IContainer container, IAccount account, string sipUri)
        {
            //var player = container.Get<IWavPlayer>();
            //player.Completed += (sender, args) =>
            //{
            //    System.Console.WriteLine("Player {0} has reached the end of file {1}", player.Id, player.File);
            //    player.Dispose();
            //};



            //player.Start("2001_theme.wav", false) ;
            //_userAgent.MediaManager.ConferenceBridge.ConnectToSoundDevice(player.ConferenceSlot.SlotId);


            ICall call = callManager.MakeCall(account, sipUri);
            
            _traceSource.TraceEvent(TraceEventType.Verbose, 10000, call.DestinationUri);


            //ICall call2 = callManager.MakeCall(
            //                x =>
            //                {
            //                    return x.To("billy").At("127.0.0.1").Through("65227")
            //                        //.From(_agent.AccountManager.GetAccountById(Convert.ToInt32(_args.From)))
            //    .Call();
            //                });
        }















        static async void CallManager_Ring(object sender, pjsip4net.Calls.RingEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("RingEventArgs"));

            ICallManager x = sender as ICallManager;

            ICall icall = x.GetCallById(e.CallId);

            if (icall.IsIncoming)
            {
                icall.Answer(true, "gggg");
            }

            CallInfo callInfo = icall.GetCallInfo();

            //pjsip4net.Calls.Call call = icall as pjsip4net.Calls.Call;

            _traceSource.TraceEvent(TraceEventType.Verbose, 0, callInfo.DumpToString("callInfo"));

            using (var bucket = Cluster.OpenBucket())
            {
                var document = new RBCallInfo
                {
                     CallID = callInfo.CallId,
                      Contact=callInfo.LocalContact,
                       CSeq=callInfo.StateText,
                        From=callInfo.RemoteContact,
                         timestamp=DateTime.Now - callInfo.TotalDuration ,
                          To=callInfo.LocalContact,
                           Via=callInfo.RemoteInfo
                };

                var upsertTask = bucket.UpsertAsync<RBCallInfo>(callInfo.CallId, document);
                upsertTask.Wait();
                //var upsert = bucket.Upsert<RBCallInfo>(callInfo.CallId, document);
                if (!upsertTask.Result.Success)
                {
                    //we need a retry of some sort here

                    //var get = bucket.GetDocument<dynamic>(document.Id);
                    //document = get.Document;
                    //var msg = string.Format("{0} {1}! {2}", document.Id, document.Content.name, document.Content.job);
                    //Console.WriteLine(msg);
                }
            }



        }

        static void CallManager_IncomingDtmfDigit(object sender, pjsip4net.Calls.DtmfEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("DtmfEventArgs"));
        }

        static void CallManager_IncomingCall(object sender, pjsip4net.Core.Utils.EventArgs<pjsip4net.Interfaces.ICall> e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("ICall"));
        }

        static void CallManager_CallTransfer(object sender, pjsip4net.Calls.CallTransferEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("CallTransferEventArgs"));
        }

        static void CallManager_CallStateChanged(object sender, pjsip4net.Calls.CallStateChangedEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("CallStateChangedEventArgs"));

            ICallManager x = sender as ICallManager;

            ICall call = x.GetCallById(e.Id);
        }

        static void CallManager_CallRedirected(object sender, pjsip4net.Calls.CallRedirectedEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("CallRedirectedEventArgs"));
        }






        static void ua_Log(object sender, pjsip4net.LogEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Critical, 0, "{0} {1}", e.Level, e.Data);
        }
    }



}
