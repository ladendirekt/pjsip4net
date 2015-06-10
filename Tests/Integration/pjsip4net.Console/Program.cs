using System;
using Castle.Windsor;
using log4net;
using log4net.Config;
using pjsip4net.Calls;
using pjsip4net.Configuration;
using pjsip4net.Container.Castle;
using pjsip4net.Core;
using pjsip4net.Core.Configuration;
using pjsip4net.Core.Data;

namespace pjsip4net.Console
{
    public class Program
    {
        private static ILog _logger;

        public static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            _logger = LogManager.GetLogger("root");//logging is purely an application facility, you can choose whatever you want to log with
            var container = new WindsorContainer();
            var cfg = Configure.Pjsip4Net()//dynamically discovers interop assembly and loads API providers unless concrete version loader specified
                .With_CastleContainer(container)//plugs an existing DI-container
                .FromConfig();//read configuration from .config file 
            var ua = cfg.Build().Start();//build and start
            ua.ImManager.IncomingMessage += IncomingMessage;
            ua.CallManager.CallRedirected += CallRedirected;
            ua.CallManager.IncomingDtmfDigit += IncomingDtmfDigit;
            ua.ImManager.NatDetected += OnNatDetected;
            ua.CallManager.IncomingCall += CallManager_IncomingCall;
            ua.CallManager.CallStateChanged += CallManager_CallStateChanged;
            var factory = new CommandFactory(ua, cfg.Container);
            factory.Create("?").Execute();

            while (true)
            {
                try
                {
                    var line = System.Console.ReadLine();
                    if (string.IsNullOrEmpty(line))
                        break;
                    var command = factory.Create(line);
                    command.Execute();
                }
                catch(PjsipErrorException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
                catch(SystemException ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
            }
            ua.Destroy();
        }

        static void CallManager_CallStateChanged(object sender, CallStateChangedEventArgs e)
        {
            System.Console.BackgroundColor = ConsoleColor.Blue;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Call to {0}: {1}", e.DestinationUri, e.Duration);
            System.Console.ResetColor();
        }

        static void CallManager_IncomingCall(object sender, Core.Utils.EventArgs<Interfaces.ICall> e)
        {
            System.Console.BackgroundColor = ConsoleColor.Cyan;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Incoming call from: {0}", e.Data.RemoteContact);
            System.Console.ResetColor();
        }

        private static void OnNatDetected(object s, NatEventArgs ea)
        {
            System.Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("NAT type detection complete: {0}; {1}", ea.NatTypeName, ea.StatusText);
            System.Console.ResetColor();
        }

        private static void IncomingDtmfDigit(object sender, DtmfEventArgs eventArgs)
        {
            System.Console.BackgroundColor = ConsoleColor.DarkGreen;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Call {0} received {1} digits", eventArgs.CallId, eventArgs.Digit);
            System.Console.ResetColor();
        }

        static void IncomingMessage(object sender, PagerEventArgs e)
        {
            System.Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("Message from " + e.From + ", text: " + e.Body);
            System.Console.ResetColor();
        }

        static void CallRedirected(object sender, CallRedirectedEventArgs e)
        {
            System.Console.BackgroundColor = ConsoleColor.DarkGray;
            System.Console.ForegroundColor = ConsoleColor.White;
            e.Option = RedirectOption.Accept;
            System.Console.ResetColor();
        }
    }
}