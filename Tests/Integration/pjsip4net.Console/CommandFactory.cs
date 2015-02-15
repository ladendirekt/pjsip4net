using System;
using System.Linq;
using Magnum.CommandLineParser;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;
using pjsip4net.Interfaces;

namespace pjsip4net.Console
{
    public class CommandFactory : ICommandFactory
    {
        private readonly ISipUserAgent _userAgent;
        private readonly IContainer _container;
        private readonly ICommandLineParser _parser = new MonadicCommandLineParser();

        public CommandFactory(ISipUserAgent userAgent, IContainer container)
        {
            _userAgent = userAgent;
            _container = container;
        }

        #region Implementation of ICommandFactory

        public ICommand Create(string cmd)
        {
            var cmdElements = _parser.Parse(cmd);
            var argument = cmdElements.OfType<ArgumentElement>().First();
            var definitions = cmdElements.OfType<DefinitionElement>().ToArray();
            switch (argument.Id)
            {
                case "register":
                    return new RegisterAccountCommand(_userAgent, new RegisterAccountArguments
                    {
                        Domain = definitions.First(x => x.Key == "d").Value,
                        Extension = definitions.First(x => x.Key == "e").Value,
                        Password = definitions.First(x => x.Key == "p").Value,
                        Port = definitions.First(x => x.Key == "Port").Value,
                        Transport = definitions.First(x => x.Key == "t").Value
                    });
                case "accounts":
                    return new ShowAccountsCommand(_userAgent);
                case "unregister":
                    return new UnregisterAccountCommand(_userAgent,
                        new IdArguments {Id = definitions.First(x => x.Key == "i").Value});
                case "codecs":
                    return new ShowCodecsCommand(_userAgent);
                case "setcodec":
                    return new SetCodecCommand(_userAgent, new CodecArguments
                    {
                        Channels = definitions.First(x => x.Key == "Channels").Value,
                        CodecId = definitions.First(x => x.Key == "c").Value,
                        Frequency = definitions.First(x => x.Key == "f").Value,
                        Priority = definitions.First(x => x.Key == "p").Value,
                    });
                case "devices":
                    return new ShowDevicesCommand(_userAgent);
                case "setdevice":
                    return new SetDeviceCommand(_userAgent, new DeviceArguments
                    {
                        CaptureId = definitions.First(x => x.Key == "c").Value,
                        PlaybackId = definitions.First(x => x.Key == "p").Value,
                    });
                case "calls":
                    return new ShowCallsCommand(_userAgent);
                case "makecall":
                    return new MakeCallCommand(_userAgent, new CallArguments
                    {
                        At = definitions.First(x => x.Key == "a").Value,
                        From = definitions.First(x => x.Key == "f").Value,
                        Through = definitions.First(x => x.Key == "Through").Value,
                        To = definitions.First(x => x.Key == "t").Value,
                    });
                case "hangupcall":
                    return new HangupCallCommand(_userAgent,
                        new IdArguments {Id = definitions.First(x => x.Key == "i").Value});
                case "dtmf":
                    return new SendDtmfCommand(_userAgent, new DtmfArguments
                    {
                        CallId = definitions.First(x => x.Key == "c").Value,
                        Digits = definitions.First(x => x.Key == "d").Value,
                    });
                case "xfer":
                    return new TransferCommand(_userAgent, new TransferArguments
                    {
                        CallId = definitions.First(x => x.Key == "c").Value,
                        Destination = definitions.First(x => x.Key == "d").Value,
                    });
                case "buddies":
                    return new ShowAllBuddiesCommand(_userAgent);
                case "registerbuddy":
                    return new RegisterBuddyCommand(_userAgent, new RegisterBuddyArguments
                    {
                        Domain = definitions.First(x => x.Key == "d").Value,
                        Extension = definitions.First(x => x.Key == "e").Value,
                        Port = definitions.First(x => x.Key == "Port").Value,
                        Subscribe = definitions.First(x => x.Key == "s").Value,
                        Transport = definitions.First(x => x.Key == "t").Value,
                    });
                case "unregisterbuddy":
                    return new UnregisterBuddyCommand(_userAgent,
                        new IdArguments {Id = definitions.First(x => x.Key == "i").Value});
                case "dumpsub":
                    return new DumpSubscriptionCommand(_userAgent, new DumpSubscriptionArguments
                    {
                        Verbose = definitions.First(x => x.Key == "v").Value
                    });
                case "im":
                    return new SendImCommand(_userAgent, new ImArguments
                    {
                        At = definitions.First(x => x.Key == "a").Value,
                        Body = definitions.First(x => x.Key == "b").Value,
                        From = definitions.First(x => x.Key == "f").Value,
                        InDialog = definitions.First(x => x.Key == "i").Value,
                        Through = definitions.First(x => x.Key == "Through").Value,
                        To = definitions.First(x => x.Key == "t").Value,
                    }, _container.Get<IMessageBuilder>());
                case "playertest" : 
                    return new PlayFileCommand(_userAgent, _container);
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

    public class TransferCommand : ICommand
    {
        private ISipUserAgent _userAgent;
        private TransferArguments _arguments;

        public TransferCommand(ISipUserAgent userAgent, TransferArguments transferArguments)
        {
            _userAgent = userAgent;
            _arguments = transferArguments;
        }

        public void Execute()
        {
            _userAgent.CallManager.GetCallById(int.Parse(_arguments.CallId)).Transfer(_arguments.Destination);
        }
    }

    public class SendImCommand : ICommand
    {
        private readonly ISipUserAgent _agent;
        private readonly ImArguments _arguments;
        private readonly IMessageBuilder _messageBuilder;

        public SendImCommand(ISipUserAgent agent, ImArguments arguments, IMessageBuilder messageBuilder)
        {
            _agent = agent;
            _arguments = arguments;
            _messageBuilder = messageBuilder;
        }

        #region Implementation of ICommand

        public void Execute()
        {
            _messageBuilder.To(_arguments.To).At(_arguments.At).From(
                _agent.AccountManager.GetAccountById(Convert.ToInt32(_arguments.From))).WithBody(_arguments.Body);
            if (!string.IsNullOrEmpty(_arguments.Through))
                _messageBuilder.Through(_arguments.Through);
            if (!string.IsNullOrEmpty(_arguments.InDialog))
                _messageBuilder.InDialogOf(_agent.CallManager.GetCallById(Convert.ToInt32(_arguments.InDialog)));

            _messageBuilder.Send();
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
            _agent.AccountManager.Register(x =>
            {
                x.WithExtension(_arguments.Extension).WithPassword(
                    _arguments.Password);
                if (_arguments.Port != null)
                    x.Through(_arguments.Port);
                return x.At(_arguments.Domain).Register();
            });
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
            System.Console.WriteLine("Default account");
            System.Console.WriteLine(_agent.AccountManager.DefaultAccount.Id + " " +
                                     _agent.AccountManager.DefaultAccount.AccountId + " " +
                                     _agent.AccountManager.DefaultAccount.StatusText);
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
            _agent.ImManager.RegisterBuddy(x =>
            {
                x.WithName(_arguments.Extension)
                    .At(_arguments.Domain);

                if (_arguments.Port != null)
                    x.Through(_arguments.Port);
                if (Convert.ToBoolean(_arguments.Subscribe))
                    x.Subscribing();

                return x.Register();
            });
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
            if (_agent.MediaManager.CurrentPlaybackDevice != null)
                System.Console.WriteLine(_agent.MediaManager.CurrentPlaybackDevice.Id + " " + 
                                         _agent.MediaManager.CurrentPlaybackDevice.Name);
            System.Console.Write("Current capture device - ");
            if (_agent.MediaManager.CurrentCaptureDevice != null)
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
            _agent.CallManager.MakeCall(x => x.To(_args.To).At(_args.At).Through(_args.Through)
                .From(_agent.AccountManager.GetAccountById(Convert.ToInt32(_args.From))).RecordTo("test.wav").Call());
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

    public class PlayFileCommand : ICommand
    {
        private readonly ISipUserAgent _userAgent;
        private readonly IContainer _container;

        public PlayFileCommand(ISipUserAgent userAgent, IContainer container)
        {
            _userAgent = userAgent;
            _container = container;
        }

        public void Execute()
        {
            var player = _container.Get<IWavPlayer>();
            player.Completed += (sender, args) =>
            {
                System.Console.WriteLine("Player {0} has reached the end of file {1}", player.Id, player.File);
                player.Dispose();
            };
            player.Start("NeroSoundTrax_test8_PCM_Mono_VBR_16SS_48000Hz.wav", false) ;
            _userAgent.MediaManager.ConferenceBridge.ConnectToSoundDevice(player.ConferenceSlot.SlotId);
        }
    }
}