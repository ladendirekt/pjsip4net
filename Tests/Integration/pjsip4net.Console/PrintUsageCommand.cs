namespace pjsip4net.Console
{
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
            System.Console.WriteLine("=   <-p:1234>        | *Password or p          =");
            System.Console.WriteLine("=   <-Port:5060>     | *Port                   =");
            System.Console.WriteLine("=   <-t:udp,tcp,tls> | *Transport or t         =");
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
            System.Console.WriteLine("=   <-Through:5060>  | *Through                =");
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
            System.Console.WriteLine("=   <-Port:5060>     | *Port                   =");
            System.Console.WriteLine("=   <-t:udp,tcp,tls> | *Transport or t         =");
            System.Console.WriteLine("=   <-s:true>        | *Subscribe or s         =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= unregisterbuddy    | <delete buddy>         =");
            System.Console.WriteLine("=   <-i:1>           | *Id or i               =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= buddies            | <show all buddies>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= dumpsub            | <log subscription>     =");
            System.Console.WriteLine("===============================================");
            System.Console.WriteLine("= im                 | <send message>         =");
            System.Console.WriteLine("=   <-t:user>         | *To or t               =");
            System.Console.WriteLine("=   <-a:pjsip.org>    | *At or a               =");
            System.Console.WriteLine("=   <-Through:5060>   | *Through                =");
            System.Console.WriteLine("=   <-f:1 (acc. id)>  | *From or f             =");
            System.Console.WriteLine("=   <-i:1 (call id)>  | *InDialog or i         =");
            System.Console.WriteLine("=   <-b:hello>        | *Body or b             =");
            System.Console.WriteLine("===============================================");
        }

        #endregion
    }
}