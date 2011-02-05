using System;

namespace pjsip4net.Core.Utils
{
    //public static class SingletonHolder<TSingleton>
    //    where TSingleton : class
    //{
    //    private static readonly object _lock = new object();
    //    private static TSingleton _instance;

    //    private static Func<TSingleton> InstanceInjector;

    //    public static TSingleton Instance
    //    {
    //        get
    //        {
    //            if (_instance == null)
    //                lock (_lock)
    //                    if (_instance == null)
    //                    {
    //                        Helper.GuardNotNull(InstanceInjector);
    //                        _instance = InstanceInjector();
    //                    }
    //            return _instance;
    //        }
    //    }

    //    public static void SetInstanceInjector(Func<TSingleton> injector)
    //    {
    //        Helper.GuardNotNull(injector);
    //        lock (_lock)
    //        {
    //            if (InstanceInjector != null)
    //                _instance = null;
    //            InstanceInjector = injector;
    //        }
    //    }
    //}
}