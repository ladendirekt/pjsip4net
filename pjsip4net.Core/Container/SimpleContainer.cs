using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Magnum.Collections;
using pjsip4net.Core.Interfaces;
using pjsip4net.Core.Utils;

namespace pjsip4net.Core.Container
{
    public class SimpleContainer : IContainer
    {
        private IDictionary<string, object> _namedRegistry = new Dictionary<string, object>();
        private IDictionary<Type, ICollection<Type>> _transientRegistry = new MultiDictionary<Type, Type>(false);
        private IDictionary<Type, ICollection<object>> _singletonRegistry = new MultiDictionary<Type, object>(false);

        private static void Invariant(bool condition)
        {
            if (!condition)
                throw new ContainerException();
        }

        #region Implementation of IContainer

        public IContainer Register<T, T1>() where T1 : T
        {
            AddToTransientRegistry(typeof(T), typeof(T1));
            return this;
        }

        public IContainer Register<T, T1>(string name) where T1 : T
        {
            Invariant(!_namedRegistry.ContainsKey(name));
            _namedRegistry.Add(name, typeof(T1));
            return this;
        }

        public IContainer RegisterAsSingleton<T, T1>() where T1 : T
        {
            AddToSingletonRegistry(typeof (T),
                                   Activator.CreateInstance(typeof (T1), DetermineConstructorArgs(typeof (T1))));
            return this;
        }

        public IContainer RegisterAsSingleton<T, T1>(string name) where T1 : T
        {
            Invariant(!_namedRegistry.ContainsKey(name));
            _namedRegistry.Add(name, Activator.CreateInstance(typeof (T1), DetermineConstructorArgs(typeof (T1))));
            return this;
        }

        public IContainer RegisterAsSingleton<T>(T instance)
        {
            AddToSingletonRegistry(typeof(T), instance);
            return this;
        }

        public IContainer RegisterAsSingleton<T>(T instance, string name)
        {
            Invariant(!_namedRegistry.ContainsKey(name));
            _namedRegistry.Add(name, instance);
            return this;
        }

        public T Get<T>()
        {
            return (T) Get(typeof(T));
        }

        public object Get(Type service)
        {
            if (_singletonRegistry.ContainsKey(service))
                return _singletonRegistry[service].First(); 
            if (_transientRegistry.ContainsKey(service))
                return Activator.CreateInstance(_transientRegistry[service].First(),
                                                DetermineConstructorArgs(_transientRegistry[service].First()));
            return
                _namedRegistry
                    .Where(kvp =>
                           !kvp.Value.GetType().Equals(typeof (Type)) && service.IsAssignableFrom(kvp.Value.GetType()))
                    .Select(kvp => kvp.Value)
                    .Union(_namedRegistry
                               .Where(kvp => kvp.Value is Type && service.IsAssignableFrom((Type) kvp.Value))
                               .Select(kvp =>
                                       Activator.CreateInstance((Type) kvp.Value,
                                                                DetermineConstructorArgs((Type) kvp.Value))))
                    .FirstOrDefault();
        }

        public T Get<T>(string name)
        {
            return (T) Get(name, typeof (T));
        }

        public object Get(string name, Type service)
        {
            if (!_namedRegistry.ContainsKey(name))
                return null;

            return _namedRegistry
                .Where(kvp => kvp.Key.Equals(name) &&
                              (!kvp.Value.GetType().Equals(typeof (Type)) &&
                               service.IsAssignableFrom(kvp.Value.GetType())))
                .Select(kvp => kvp.Value)
                .Union(_namedRegistry.Where(kvp => kvp.Key.Equals(name) &&
                                                   ((kvp.Value is Type &&
                                                     service.IsAssignableFrom((Type) kvp.Value))))
                           .Select(kvp =>
                                   Activator.CreateInstance((Type) kvp.Value,
                                                            DetermineConstructorArgs((Type) kvp.Value))))
                .FirstOrDefault();
        }

        public IList<T> GetAll<T>()
        {
            return GetAll(typeof (T)).Cast<T>().ToList();
        }

        public IList GetAll(Type service)
        {
            var result = new List<object>();
            return _transientRegistry
                .Where(kvp => kvp.Key.Equals(service))
                .SelectMany(kvp =>
                                {
                                    kvp.Value.Each(t =>
                                                   result.Add(
                                                       Activator.CreateInstance(t, DetermineConstructorArgs(t))));
                                    return result;
                                })
                .Union(_singletonRegistry
                           .Where(kvp => kvp.Key.Equals(service))
                           .SelectMany(kvp =>
                                           {
                                               kvp.Value.Each(result.Add);
                                               return result;
                                           }))
                .Union(_namedRegistry
                           .Where(kvp => !kvp.Value.GetType().Equals(typeof (Type))
                                         && service.IsAssignableFrom(kvp.Value.GetType()))
                           .Select(kvp => kvp.Value)
                           .Union(_namedRegistry
                                      .Where(kvp => (kvp.Value is Type && service.IsAssignableFrom((Type) kvp.Value)))
                                      .Select(kvp =>
                                              Activator.CreateInstance((Type) kvp.Value,
                                                                       DetermineConstructorArgs((Type) kvp.Value)))))

                .ToList();
        }

        #endregion

        private void AddToTransientRegistry(Type service, Type implementation)
        {
            if (_transientRegistry.ContainsKey(service))
                _transientRegistry[service].Add(implementation);
            else
                _transientRegistry.Add(service, new List<Type>() { implementation });
        }

        private void AddToSingletonRegistry(Type service, object implementation)
        {
            if (_singletonRegistry.ContainsKey(service))
                _singletonRegistry[service].Add(implementation);
            else
                _singletonRegistry.Add(service, new List<object>() { implementation });
        }

        protected object[] DetermineConstructorArgs(Type implementation)
        {
            var args = new List<object>();
            var constructor = implementation.SelectEligibleConstructor();

            if (constructor != null)
                constructor.GetParameters().Each(p => args.Add(Get(p.ParameterType)));

            return args.ToArray();
        }

    }
}