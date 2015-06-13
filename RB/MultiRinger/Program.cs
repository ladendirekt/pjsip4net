using pjsip4net.Core.Configuration;
//using pjsip.Interop;
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
using pjsip4net.Core.Utils;
using Couchbase.Core;

namespace MultiRinger
{
    class Program
    {
        private static readonly TraceSource _traceSource = new TraceSource("MultiRinger", SourceLevels.Error);

        private static readonly Cluster Cluster = new Cluster("couchbaseClients/couchbase");
        private static readonly IBucket bucket = Cluster.OpenBucket();
            
        static void Main(string[] args)
        {
            _traceSource.TraceInformation("starting " + AppDomain.CurrentDomain.FriendlyName + "_" + AppDomain.CurrentDomain.Id);

            pjsip4net.Interfaces.ISipUserAgent ua = null;

            try
            {
                var pj = Configure.Pjsip4Net();
                Console.WriteLine("prepare to configure pjsip");

                // right now we appear to NEED to register the transport like this,
                // the configuration is not allowing for port 0 to randomize

                pj.FromConfig().With(o =>
                {
                    o.Config.ThreadCount = 5;

                    var transportType = new pjsip4net.Core.Data.TransportConfig();
                    transportType.BoundAddress = "0.0.0.0";
                    //transportType.Port = 5080;
                    transportType.PublicAddress = "0.0.0.0";
                    var trspt = new pjsip4net.Core.Utils.Tuple<pjsip4net.Core.TransportType, pjsip4net.Core.Data.TransportConfig>
                        (pjsip4net.Core.TransportType.Udp, transportType);
                    o.RegisterTransport(trspt);
                });

                var container = new WindsorContainer();
                var cfg = pj.With_CastleContainer(container);//plugs an existing DI-container

                ua = cfg.Build();
                Console.WriteLine("configuration complete and built");


                ua.Log += ua_Log;
                Console.WriteLine("preparing to start");

                ua.CallManager.CallRedirected += CallManager_CallRedirected;
                ua.CallManager.CallStateChanged += CallManager_CallStateChanged;
                ua.CallManager.CallTransfer += CallManager_CallTransfer;
                ua.CallManager.IncomingCall += CallManager_IncomingCall;
                ua.CallManager.IncomingDtmfDigit += CallManager_IncomingDtmfDigit;

                ua.CallManager.MaxCalls = 100;
                ua.CallManager.Ring += CallManager_Ring;

                ua.Start();



                //register as who we are?

                //we want multiples of this process running. But yet we want to be able to
                //identify the process (probably to be able to see if it died and recover its problems

                IAccount account = ua.AccountManager.Register(new Func<IAccountBuilder, IAccount>(o =>
                {
                    return o.At("local-rb").WithExtension("BRC1").Register();
                }));


                MakeACall(ua.CallManager, cfg.Container, account, @"sip:externalparty@local-rb");
                MakeACall(ua.CallManager, cfg.Container, account, @"sip:externalparty2@local-rb");
                MakeACall(ua.CallManager, cfg.Container, account, @"sip:externalparty@local-rb");
                MakeACall(ua.CallManager, cfg.Container, account, @"sip:externalparty2@local-rb");

                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty2@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty2@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty2@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty@local-rb", "msg" + Guid.NewGuid().ToString("P"));
                MakeInstantMessage(ua.ImManager, account, @"sip:externalparty2@local-rb", "msg" + Guid.NewGuid().ToString("P"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);

                //we are going to eat these
                //throw;
            }
            Console.WriteLine("in process.. hit return to exit");

            Console.ReadLine();

            try
            {
                if (ua != null)
                {
                    ua.CallManager.HangupAll();
                    ua.Destroy(); 
                    if (ua != null)
                    {
                        ua.Dispose();
                    }
                }
                
                if(bucket!=null)
                {
                    bucket.Dispose();
                }
                if(Cluster!=null)
                {
                    Cluster.Dispose();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }


        #region Operations

        private static void MakeACall(ICallManager callManager, pjsip4net.Core.Interfaces.IContainer container, IAccount account, string sipUri)
        {
            ICall call = callManager.MakeCall(account, sipUri);

            _traceSource.TraceEvent(TraceEventType.Verbose, 10000, call.DestinationUri);
        }


        private static void MakeInstantMessage(IImManager imManager, IAccount account, string sipUri, string message)
        {
            imManager.SendMessage(account, message, sipUri);
        }

        #endregion












        static async void CallManager_Ring(object sender, pjsip4net.Calls.RingEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("RingEventArgs"));
        }

        private static async Task PersistCallState(CallInfo callInfo)
        {
            _traceSource.TraceEvent(TraceEventType.Verbose, 99, callInfo.DumpToString("callInfo"));

            var document = new RBCallInfo
            {
                //LastStatus = callInfo.LastStatus,
                //LastStatusText = callInfo.LastStatusText,


                CallID = callInfo.CallId,
                Contact = callInfo.LocalContact,
                CSeq = callInfo.LastStatusText,
                From = callInfo.LocalInfo,
                timestamp = DateTime.Now - callInfo.TotalDuration,
                To = callInfo.RemoteContact,
                Via = callInfo.RemoteInfo
            };

            //var upsert = bucket.Upsert<RBCallInfo>(callInfo.CallId, document);
            await bucket.UpsertAsync<RBCallInfo>(callInfo.CallId, document);
        }

        static async void CallManager_CallStateChanged(object sender, pjsip4net.Calls.CallStateChangedEventArgs e)
        {
            _traceSource.TraceEvent(TraceEventType.Information, 0, e.DumpToString("CallStateChangedEventArgs"));

            ICallManager callmgr = sender as ICallManager;
            if (callmgr != null)
            {
                ICall call = callmgr.GetCallById(e.Id);
                if (call != null)
                {
                    CallInfo callInfo = call.GetCallInfo();

                    await PersistCallState(callInfo);
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
