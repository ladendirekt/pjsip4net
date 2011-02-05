using System;
using System.Linq;
using Magnum.CommandLine;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Console
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ISipUserAgent _userAgent;
        private readonly CommandLineParser _parser = new CommandLineParser();

        public CommandFactory(ISipUserAgent userAgent)
        {
            _userAgent = userAgent;
            _parser.RegisterArgumentsForCommand<RegisterAccountArguments>("register");
            _parser.RegisterArgumentsForCommand<IdArguments>("unregister");
            _parser.RegisterArgumentsForCommand<NullArguments>("accounts");
            _parser.RegisterArgumentsForCommand<NullArguments>("codecs");
            _parser.RegisterArgumentsForCommand<CodecArguments>("setcodec");
            _parser.RegisterArgumentsForCommand<DeviceArguments>("setdevice");
            _parser.RegisterArgumentsForCommand<NullArguments>("devices");
            _parser.RegisterArgumentsForCommand<NullArguments>("calls");
            _parser.RegisterArgumentsForCommand<CallArguments>("makecall");
            _parser.RegisterArgumentsForCommand<DtmfArguments>("dtmf");
            _parser.RegisterArgumentsForCommand<IdArguments>("hangupcall");
            _parser.RegisterArgumentsForCommand<NullArguments>("buddies");
            _parser.RegisterArgumentsForCommand<RegisterBuddyArguments>("registerbuddy");
            _parser.RegisterArgumentsForCommand<IdArguments>("unregisterbuddy");
            _parser.RegisterArgumentsForCommand<DumpSubscriptionArguments>("dumpsub");
            _parser.RegisterArgumentsForCommand<ImArguments>("im");
            _parser.RegisterArgumentsForCommand<NullArguments>("?");
            _parser.RegisterArgumentsForCommand<NullArguments>("print");
            _parser.RegisterArgumentsForCommand<NullArguments>("help");
            //System.Console.WriteLine(_parser.WhatsRegistered());
        }

        #region Implementation of ICommandFactory

        public ICommand Create(string cmd)
        {
            var output = _parser.Parse(cmd.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries));
            switch (output.CommandName)
            {
                case "register":
                    return new RegisterAccountCommand(_userAgent, output.ParsedArguments.As<RegisterAccountArguments>());
                case "accounts":
                    return new ShowAccountsCommand(_userAgent);
                case "unregister":
                    return new UnregisterAccountCommand(_userAgent, output.ParsedArguments.As<IdArguments>());
                case "codecs":
                    return new ShowCodecsCommand(_userAgent);
                case "setcodec":
                    return new SetCodecCommand(_userAgent,output.ParsedArguments.As<CodecArguments>());
                case "devices":
                    return new ShowDevicesCommand(_userAgent);
                case "setdevice":
                    return new SetDeviceCommand(_userAgent, output.ParsedArguments.As<DeviceArguments>());
                case "calls":
                    return new ShowCallsCommand(_userAgent);
                case "makecall":
                    return new MakeCallCommand(_userAgent, output.ParsedArguments.As<CallArguments>());
                case "hangupcall":
                    return new HangupCallCommand(_userAgent, output.ParsedArguments.As<IdArguments>());
                case "dtmf":
                    return new SendDtmfCommand(_userAgent, output.ParsedArguments.As<DtmfArguments>());
                case "buddies":
                    return new ShowAllBuddiesCommand(_userAgent);
                case "registerbuddy":
                    return new RegisterBuddyCommand(_userAgent, output.ParsedArguments.As<RegisterBuddyArguments>());
                case "unregisterbuddy":
                    return new UnregisterBuddyCommand(_userAgent, output.ParsedArguments.As<IdArguments>());
                case "dumpsub":
                    return new DumpSubscriptionCommand(_userAgent,
                                                       output.ParsedArguments.As<DumpSubscriptionArguments>());
                case "im":
                    return new SendImCommand(_userAgent, output.ParsedArguments.As<ImArguments>());
                case "?":
                case "help":
                case "print":
                    return new PrintUsageCommand();
                default:
                    return new NoOpCommand();
            }
        }

        #endregion
    }

    public class SendImCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly ImArguments _arguments;

        public SendImCommand(ISipUserAgent agent, ImArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            var builder = _agent.Container.Get<IMessageBuilder>().To(_arguments.To).At(_arguments.At).From(
                _agent.AccountManager.GetAccountById(Convert.ToInt32(_arguments.From))).WithBody(_arguments.Body);
            if (!string.IsNullOrEmpty(_arguments.Through))
                builder = builder.Through(_arguments.Through);
            if (!string.IsNullOrEmpty(_arguments.InDialog))
                builder = builder.InDialogOf(_agent.CallManager.GetCallById(Convert.ToInt32(_arguments.InDialog)));

            builder.Send();
        }

        #endregion
    }

    public class DumpSubscriptionCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly DumpSubscriptionArguments _arguments;

        public DumpSubscriptionCommand(ISipUserAgent agent, DumpSubscriptionArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            _agent.ImManager.DumpSubscription(Convert.ToBoolean(_arguments.Verbose));
        }

        #endregion
    }

    public class PrintUsageCommand : ICommand
    {
        #region Implementation of ICommand

        public void Execute()
        {
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= Available commands | Command arguments      =");
            System.Console.WriteLine("= <argument example> | <command description>  =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= ? or help or print | <print this table>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= register           | <register on server>   =");
            System.Console.WriteLine("=   <-e:user>        | *Extension or e        =");
            System.Console.WriteLine("=   <-d:pjsip.org>   | *Domain or d           =");
            System.Console.WriteLine("=   <-p:1234>        | Password or p          =");
            System.Console.WriteLine("=   <-Port:5060>     | Port                   =");
            System.Console.WriteLine("=   <-t:udp,tcp,tls> | Transport or t         =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= unregister         | <delete registration>  =");
            System.Console.WriteLine("=   <-i:1>           | *Id or i               =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= accounts           | <show all accounts>    =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= setcodec           | <set codec priority>   =");
            System.Console.WriteLine("=   <-c:speex>       | *CodecId or c          =");
            System.Console.WriteLine("=   <-f:8000>        | *Frequency or f        =");
            System.Console.WriteLine("=   <-Channels:2>    | *Channels              =");
            System.Console.WriteLine("=   <-p:42>          | *Priority or p         =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= codecs             | <show all codecs>      =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= setdevice          | <set devices>          =");
            System.Console.WriteLine("=   <-p:0>           | *PlaybackId or p       =");
            System.Console.WriteLine("=   <-c:2>           | *CaptureId or c        =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= devices            | <show all devices>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= makecall           | <literally>            =");
            System.Console.WriteLine("=   <-t:user1>       | *To or t               =");
            System.Console.WriteLine("=   <-a:pjsip.org>   | *At or a               =");
            System.Console.WriteLine("=   <-f:1 (acc. id)> | *From or f             =");
            System.Console.WriteLine("=   <-Through:5060>  | Through                =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= hangupcall         | <literally>            =");
            System.Console.WriteLine("=   <-i:1>           | *Id or i               =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= dtmf               | <send dtmf digits>     =");
            System.Console.WriteLine("=   <-c:1>           | *CallId or c           =");
            System.Console.WriteLine("=   <-d:12345>       | *Digits or d           =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= calls              | <show all calls>       =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= registerbuddy      | <register buddy>       =");
            System.Console.WriteLine("=   <-e:user>        | *Extension or e        =");
            System.Console.WriteLine("=   <-d:pjsip.org>   | *Domain or d           =");
            System.Console.WriteLine("=   <-Port:5060>     | Port                   =");
            System.Console.WriteLine("=   <-t:udp,tcp,tls> | Transport or t         =");
            System.Console.WriteLine("=   <-s:true>        | Subscribe or s         =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= unregisterbuddy    | <delete buddy>         =");
            System.Console.WriteLine("=   <-i:1>           | *Id or i               =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= buddies            | <show all buddies>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= dumpsub            | <log subscription>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= im                 | <send message>         =");
            System.Console.WriteLine("=   <t:user>         | *To or t               =");
            System.Console.WriteLine("=   <a:pjsip.org>    | *At or a               =");
            System.Console.WriteLine("=   <Through:5060>   | Through                =");
            System.Console.WriteLine("=   <f:1 (acc. id)>  | *From or f             =");
            System.Console.WriteLine("=   <i:1 (call id)>  | *InDialog or i         =");
            System.Console.WriteLine("=   <b:hello>        | *Body or b             =");
            System.Console.WriteLine("===============================================");
        }

        #endregion
    }

    public class NoOpCommand : ICommand
    {
        public void Execute()
        {
        }
    }

    public class QuitCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public QuitCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            _agent.Destroy();
        }

        #endregion
    }

    public class RegisterAccountCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly RegisterAccountArguments _arguments;

        public RegisterAccountCommand(ISipUserAgent agent, RegisterAccountArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            var builder =
                _agent.Container.Get<IAccountBuilder>().WithExtension(_arguments.Extension).WithPassword(
                    _arguments.Password);
            if (_arguments.Port != null)
                builder.Through(_arguments.Port);
            builder.At(_arguments.Domain).Register();
        }

        #endregion
    }

    public class ShowAccountsCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public ShowAccountsCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        public void Execute()
        {
            System.Console.WriteLine("Available accounts");
            _agent.AccountManager.Accounts.Each(x => System.Console.WriteLine(x.Id + " " + x.AccountId + " " +
                                                                              x.StatusText));
        }
    }

    public class UnregisterAccountCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly IdArguments _args;

        public UnregisterAccountCommand(ISipUserAgent agent, IdArguments args)
        {
            _agent = agent;
            _args = args;
        }

        public void Execute()
        {
            _agent.AccountManager.GetAccountById(int.Parse(_args.Id)).Unregister();
        }
    }

    public class ShowAllBuddiesCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public ShowAllBuddiesCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            System.Console.WriteLine("Registered buddies");
            _agent.ImManager.Buddies.Each(
                x => System.Console.WriteLine(x.Id + " " + x.Uri + " " + x.StatusText));
        }

        #endregion
    }

    public class RegisterBuddyCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly RegisterBuddyArguments _arguments;

        public RegisterBuddyCommand(ISipUserAgent agent, RegisterBuddyArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            var builder = _agent.Container.Get<IBuddyBuilder>().WithName(_arguments.Extension)
                .At(_arguments.Domain);

            if (_arguments.Port != null)
                builder = builder.Through(_arguments.Port);
            if (Convert.ToBoolean(_arguments.Subscribe))
                builder = builder.Subscribing();

            builder.Register();
        }

        #endregion
    }

    public class UnregisterBuddyCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly IdArguments _arguments;

        public UnregisterBuddyCommand(ISipUserAgent agent, IdArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            _agent.ImManager.GetBuddyById(Convert.ToInt32(_arguments.Id)).Unregister();
        }

        #endregion
    }

    public class SetCodecCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly CodecArguments _args;

        public SetCodecCommand(ISipUserAgent agent, CodecArguments args)
        {
            _agent = agent;
            _args = args;
        }

        public void Execute()
        {
            _agent.MediaManager.Codecs.Single(x =>
                                              x.CodecId.Equals(
                                                  string.Concat(_args.CodecId + "/" + _args.Frequency + "/" +
                                                                _args.Channels)))
                .Priority = byte.Parse(_args.Priority);
        }
    }

    public class ShowCodecsCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public ShowCodecsCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        public void Execute()
        {
            System.Console.WriteLine("Available codecs (name & priority)");
            _agent.MediaManager.Codecs.Each(x => System.Console.WriteLine(x.CodecId + " " + x.Priority));
        }
    }

    public class SetDeviceCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly DeviceArguments _args;

        public SetDeviceCommand(ISipUserAgent agent, DeviceArguments args)
        {
            _agent = agent;
            _args = args;
        }

        public void Execute()
        {
            _agent.MediaManager.SetSoundDevices(int.Parse(_args.PlaybackId), int.Parse(_args.CaptureId));
        }
    }

    public class ShowDevicesCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public ShowDevicesCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        public void Execute()
        {
            System.Console.Write("Current playback device - ");
            System.Console.WriteLine(_agent.MediaManager.CurrentPlaybackDevice.Id + " " + 
                _agent.MediaManager.CurrentPlaybackDevice.Name);
            System.Console.Write("Current capture device - ");
            System.Console.WriteLine(_agent.MediaManager.CurrentCaptureDevice.Id + " " + 
                _agent.MediaManager.CurrentCaptureDevice.Name);
            System.Console.WriteLine("---------------------------");
            System.Console.WriteLine("Available playback devices");
            _agent.MediaManager.PlaybackDevices.Each(x => System.Console.WriteLine(x.Id + " " + x.Name));
            System.Console.WriteLine("Available capture devices");
            _agent.MediaManager.CaptureDevices.Each(x => System.Console.WriteLine(x.Id + " " + x.Name));
        }
    }

    public class ShowCallsCommand : ICommand
    {
        private readonly ISipUserAgent _agent;

        public ShowCallsCommand(ISipUserAgent agent)
        {
            _agent = agent;
        }

        public void Execute()
        {
            System.Console.WriteLine("Active calls");
            _agent.CallManager.Calls.Each(x => System.Console.WriteLine(x.Id + " " + x.ToString(true)));
        }
    }

    public class MakeCallCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly CallArguments _args;

        public MakeCallCommand(ISipUserAgent agent, CallArguments args)
        {
            _agent = agent;
            _args = args;
        }

        public void Execute()
        {
            _agent.Container.Get<ICallBuilder>().To(_args.To).At(_args.At).Through(_args.Through)
                .From(_agent.AccountManager.GetAccountById(Convert.ToInt32(_args.From))).Call();
        }
    }

    public class HangupCallCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly IdArguments _args;

        public HangupCallCommand(ISipUserAgent agent, IdArguments args)
        {
            _agent = agent;
            _args = args;
        }

        public void Execute()
        {
            _agent.CallManager.GetCallById(Convert.ToInt32(_args.Id)).Hangup();
        }
    }

    public class SendDtmfCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly DtmfArguments _arguments;

        public SendDtmfCommand(ISipUserAgent agent, DtmfArguments arguments)
        {
            _agent = agent;
            _arguments = arguments;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            _agent.CallManager.GetCallById(Convert.ToInt32(_arguments.CallId)).SendDtmf(_arguments.Digits);
        }

        #endregion
    }
}