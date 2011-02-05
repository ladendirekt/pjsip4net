using System;
using System.Collections;
using System.Collections.Generic;

namespace pjsip4net.Core.Interfaces
{
    public interface IContainer
    {
        IContainer Register<T, T1>() where T1 : T;
        IContainer Register<T, T1>(string name) where T1 : T;
        IContainer RegisterAsSingleton<T, T1>() where T1 : T;
        IContainer RegisterAsSingleton<T, T1>(string name) where T1 : T;
        IContainer RegisterAsSingleton<T>(T instance);
        IContainer RegisterAsSingleton<T>(T instance, string name);

        T Get<T>();
        object Get(Type service);
        T Get<T>(string name);
        object Get(string name, Type service);
        IList<T> GetAll<T>();
        IList GetAll(Type service);
    }
}