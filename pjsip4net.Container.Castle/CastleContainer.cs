using System;
using System.Collections;
using System.Collections.Generic;
using Castle.DynamicProxy;
using Castle.MicroKernel;
using Castle.MicroKernel.ComponentActivator;
using Castle.MicroKernel.Registration;
using Castle.MicroKernel.Resolvers;
using Castle.MicroKernel.SubSystems.Conversion;
using Castle.Windsor;
using pjsip4net.Core.Container;
using pjsip4net.Core.Interfaces;

namespace pjsip4net.Container.Castle
{
    /// <summary>
    /// An implementation of <see cref="IContainer"/> using Castle Windsor container under cover.
    /// </summary>
    public class CastleContainer : IContainer
    {
        private IWindsorContainer _windsorContainer;

        /// <summary>
        /// Create a new instance of <see cref="CastleContainer"/> with its' own instance of <see cref="IWindsorContainer"/>
        /// </summary>
        public CastleContainer()
        {
            _windsorContainer = new WindsorContainer();
        }

        /// <summary>
        /// Create a new instance of <see cref="CastleContainer"/> with existing <see cref="IWindsorContainer"/>.
        /// </summary>
        /// <param name="windsorContainer"></param>
        public CastleContainer(IWindsorContainer windsorContainer)
        {
            _windsorContainer = windsorContainer;
        }
        
        private T Wrap<T>(Func<T> resolve)
        {
            try
            {
                return resolve();
            }
            catch (ComponentRegistrationException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
            catch (ComponentNotFoundException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
            catch (ComponentActivatorException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
            catch (DependencyResolverException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
            catch (ConverterException ex)
            {
                throw new ContainerException(ex.Message, ex);
            }
            catch (ProxyGenerationException ex)
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
            return Wrap(() => _windsorContainer.Resolve<T>());
        }

        public object Get(Type service)
        {
            return Wrap(() => _windsorContainer.Resolve(service));
        }

        public T Get<T>(string name)
        {
            return Wrap(() => _windsorContainer.Resolve<T>(name));
        }

        public object Get(string name, Type service)
        {
            return Wrap(() => _windsorContainer.Resolve(name, service));
        }

        public IList<T> GetAll<T>()
        {
            return Wrap(() => _windsorContainer.ResolveAll<T>());
        }

        public IList GetAll(Type service)
        {
            return Wrap(() => _windsorContainer.ResolveAll(service));
        }

        #endregion
    }
}