using Common.Logging;
using pjsip4net.Core.Data.Events;

namespace pjsip4net
{
    public static class Logging
    {
         public static void Log (this ILog logger, LogRequested @event)
         {
             var message = @event.Message;
             switch (@event.Level)
             {
                 case 5:
                 case 4:
                     logger.Debug(message);
                     break;
                 case 3:
                     logger.Info(message);
                     break;
                 case 2:
                     logger.Warn(message);
                     break;
                 case 1:
                     logger.Error(message);
                     break;
                 case 0:
                     logger.Fatal(message);
                     break;
            }
         }
    }
}