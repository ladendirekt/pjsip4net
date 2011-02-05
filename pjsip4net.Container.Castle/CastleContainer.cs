using System;
using System.Collections;
using System.Collections.Generic;
using Castle.MicroKernel;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using pjsip4net.Core.Container;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Container.Castle
{
    public class CastleContainer : IContainer
    {
        private IWindsorContainer _windsorContainer;

        public CastleContainer()
        {
            _windsorContainer = new WindsorContainer();
        }

        public CastleContainer(IWindsorContainer windsorContainer)
        {
            _windsorContainer = windsorContainer;
        }

        private void Wrap(Action action)
        {
            try
            {
                action();
            }
            catch (ComponentRegistrationException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
        }

        #region Implementation of IContainer

        public IContainer Register<T, T1>() where T1 : T
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().ImplementedBy<T1>().LifeStyle.Transient));
            return this;
        }

        public IContainer Register<T, T1>(string name) where T1 : T
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().ImplementedBy<T1>().LifeStyle.Transient.Named(name)));
            return this;
        }

        public IContainer RegisterAsSingleton<T, T1>() where T1 : T
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().ImplementedBy<T1>()));
            return this;
        }

        public IContainer RegisterAsSingleton<T, T1>(string name) where T1 : T
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().ImplementedBy<T1>().Named(name)));
            return this;
        }

        public IContainer RegisterAsSingleton<T>(T instance)
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().Instance(instance)));
            return this;
        }

        public IContainer RegisterAsSingleton<T>(T instance, string name)
        {
            Wrap(() => _windsorContainer.Register(Component.For<T>().Instance(instance).Named(name)));
            return this;
        }

        public T Get<T>()
        {
            return _windsorContainer.Resolve<T>();
        }

        public object Get(Type service)
        {
            return _windsorContainer.Resolve(service);
        }

        public T Get<T>(string name)
        {
            return _windsorContainer.Resolve<T>(name);
        }

        public object Get(string name, Type service)
        {
            return _windsorContainer.Resolve(name, service);
        }

        public IList<T> GetAll<T>()
        {
            return _windsorContainer.ResolveAll<T>();
        }

        public IList GetAll(Type service)
        {
            return _windsorContainer.ResolveAll(service);
        }

        #endregion
    }
}