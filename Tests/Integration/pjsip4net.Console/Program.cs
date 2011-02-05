using System;
using log4net;
using log4net.Config;
using pjsip.Interop;
using pjsip4net.Calls;
using pjsip4net.Configuration;
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
            _logger = LogManager.GetLogger("root");
            var ua = Configure.Pjsip4Net().FromConfig().WithVersion_1_4().Build().Start();
            ua.Log += Log;
            ua.ImManager.IncomingMessage += ImManager_IncomingMessage;
            ua.CallManager.CallRedirected += CallManager_CallRedirected;
            var factory = new CommandFactory(ua);
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

        private static void Log(object sender, LogEventArgs e)
        {
            switch (e.Level)
            {
                case 5:
                case 4:
                    _logger.Debug(e.Data);
                    break;
                case 3:
                    _logger.Info(e.Data);
                    break;
                case 2:
                    _logger.Warn(e.Data);
                    break;
                case 1:
                    _logger.Error(e.Data);
                    break;
                case 0:
                    _logger.Fatal(e.Data);
                    break;
            }
        }

        static void ImManager_IncomingMessage(object sender, PagerEventArgs e)
        {
            System.Console.WriteLine("Message from " + e.From + ", text: " + e.Body);
        }

        static void CallManager_CallRedirected(object sender, CallRedirectedEventArgs e)
        {
            e.Option = RedirectOption.Accept;
        }
    }
}