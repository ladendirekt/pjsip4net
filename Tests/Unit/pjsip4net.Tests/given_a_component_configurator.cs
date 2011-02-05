using System;
using Moq;
using NUnit.Framework;
using pjsip4net.Core.Interfaces;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace pjsip4net.Tests
{
    [TestFixture]
    public abstract class given_a_component_configurator<T> where T : IConfigureComponents
    {
        protected IConfigureComponents _sut;
        protected Mock<IContainer> _container;
        protected IFixture _fixture;

        [SetUp]
        public void TestSetup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _container = _fixture.Freeze<Mock<IContainer>>();
            _sut = _fixture.CreateAnonymous<T>();
        }

        [TearDown]
        public void Teardown()
        {
            _sut = null;
            _container = null;
        }

        [Test, ExpectedException(typeof(ArgumentNullException))]
        public void when_configure_is_called_with_null_container_should_throw_exception()
        {
            _sut.Configure(null);
            Assert.Fail("Should have thrown an exception");
        }

        protected void when_configure_called()
        {
            _sut.Configure(_container.Object);
        }
    }
}