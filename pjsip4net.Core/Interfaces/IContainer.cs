using System;
using System.Collections;
using System.Collections.Generic;

namespace pjsip4net.Core.Interfaces
{
    /// <summary>
    /// An abstraction of dependency injection container.
    /// </summary>
    public interface IContainer
    {
        /// <summary>
        /// Registers <typeparamref name="T1"/> implementation of <typeparamref name="T"/> as transient service.
        /// </summary>
        IContainer Register<T, T1>() where T1 : T;
        /// <summary>
        /// Registers <typeparamref name="T1"/> implementation of <typeparamref name="T"/> as transient service with additional name.
        /// </summary>
        IContainer Register<T, T1>(string name) where T1 : T;
        /// <summary>
        /// Registers <typeparamref name="T1"/> implementation of <typeparamref name="T"/> as singleton service.
        /// </summary>
        IContainer RegisterAsSingleton<T, T1>() where T1 : T;
        /// <summary>
        /// Registers <typeparamref name="T1"/> implementation of <typeparamref name="T"/> as singleton service with additional name.
        /// </summary>
        IContainer RegisterAsSingleton<T, T1>(string name) where T1 : T;
        /// <summary>
        /// Registers <typeparamref name="T"/> instance as singleton service.
        /// </summary>
        IContainer RegisterAsSingleton<T>(T instance);
        /// <summary>
        /// Registers <typeparamref name="T"/> instance as singleton service with additional name.
        /// </summary>
        IContainer RegisterAsSingleton<T>(T instance, string name);

        /// <summary>
        /// Resolves service.
        /// </summary>
        /// <typeparam name="T">type of service to resolve.</typeparam>
        T Get<T>();
        /// <summary>
        /// Non-generic analog of Get<typeparamref name="T"/>
        /// </summary>
        /// <param name="service">type of service to resolve.</param>
        /// <returns></returns>
        object Get(Type service);
        /// <summary>
        /// Get named instance of service.
        /// </summary>
        /// <typeparam name="T">type of service to resolve.</typeparam>
        /// <param name="name">name a service was registered with.</param>
        T Get<T>(string name);
        /// <summary>
        /// Non-generic analog of Get<typeparamref name="T"/>(name)
        /// </summary>
        /// <param name="name">name a service was registered with.</param>
        /// <param name="service">type of service to resolve.</param>
        object Get(string name, Type service);
        /// <summary>
        /// Get all services with type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">type of services to resolve.</typeparam>
        IList<T> GetAll<T>();
        /// <summary>
        /// Non-generic analog of GetAll<typeparamref name="T"/>.
        /// </summary>
        /// <param name="service">type of services to resolve.</param>
        IList GetAll(Type service);
    }
}