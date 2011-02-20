using System;
using System.Linq;
using Castle.MicroKernel.Registration;
using Castle.Windsor;
using Moq;
using NUnit.Framework;
using pjsip4net.Container.Castle;
using pjsip4net.Core.Container;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_castle_container
    {
        [Test, ExpectedException(typeof(ContainerException))]
        public void when_registering_already_registered_configuration_then_it_should_throw_container_exception()
        {
            var sut = new CastleContainer();
            sut.Register<given_a_simple_container.Interfaze, given_a_simple_container.Clazz>();
            sut.Register<given_a_simple_container.Interfaze, given_a_simple_container.Clazz>();
            Assert.Fail("Should have thrown an exception");
        }

        [Test, ExpectedException(typeof(ContainerException))]
        public void when_resolving_whats_is_not_there_should_wrap_original_exception_with_container_exception()
        {
            var sut = new CastleContainer();
            sut.Get<given_a_simple_container.Interfaze>();
            Assert.Fail("Should have thrown an exception");
        }

        [Ignore]
        public void when_registering_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.Register<given_a_simple_container.Interfaze, given_a_simple_container.Clazz>();

            inner.Verify(
                x => x.Register(Match.Create<IRegistration[]>(x1 => x1.Contains(
                    Component.For<given_a_simple_container.Interfaze>()
                    .ImplementedBy<given_a_simple_container.Clazz>()
                    .LifeStyle.Transient))));
        }
        
        [Test]
        public void when_resolving_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.Get<given_a_simple_container.Interfaze>();

            inner.Verify(x => x.Resolve<given_a_simple_container.Interfaze>());
        }
        
        [Test]
        public void when_resolving_all_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.GetAll<given_a_simple_container.Interfaze>();

            inner.Verify(x => x.ResolveAll<given_a_simple_container.Interfaze>());
        }
        
        [Test]
        public void when_resolving_with_name_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.Get<given_a_simple_container.Interfaze>("anonymousName");

            inner.Verify(
                x => x.Resolve<given_a_simple_container.Interfaze>(It.Is<string>(x1 => x1.Equals("anonymousName"))));
        }
        
        [Test]
        public void when_resolving_with_type_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.Get(typeof(given_a_simple_container.Interfaze));

            inner.Verify(x => x.Resolve(It.Is<Type>(x1 => x1.Equals(typeof (given_a_simple_container.Interfaze)))));
        }
        
        [Test]
        public void when_resolving_all_with_type_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.GetAll(typeof(given_a_simple_container.Interfaze));

            inner.Verify(x => x.ResolveAll(It.Is<Type>(x1 => x1.Equals(typeof (given_a_simple_container.Interfaze)))));
        }
        
        [Test]
        public void when_resolving_with_type_and_name_obviously_should_delegate_to_underlying_container()
        {
            var inner = new Mock<IWindsorContainer>(MockBehavior.Loose);
            var sut = new CastleContainer(inner.Object);

            sut.Get("anonymousName", typeof(given_a_simple_container.Interfaze));

            inner.Verify(
                x =>
                x.Resolve(It.Is<string>(x1 => x1.Equals("anonymousName")),
                          It.Is<Type>(x1 => x1.Equals(typeof (given_a_simple_container.Interfaze)))));
        }
    }
    // ReSharper restore InconsistentNaming
}