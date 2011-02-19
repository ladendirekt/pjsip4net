using Moq;
using NUnit.Framework;
using pjsip4net.Configuration;
using pjsip4net.Core.Configuration;
using pjsip4net.Core.Container;
using pjsip4net.Core.Interfaces;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_configure
    {
        private Configure _sut;
        private Mock<IContainer> _container;
        protected IFixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture().Customize(new AutoMoqCustomization());
            _sut = _fixture.CreateAnonymous<Configure>();//.WithVersion_For_Tests();
            _container = _fixture.Freeze<Mock<IContainer>>();
        }

        [TearDown]
        public void Teardown()
        {
            _sut = null;
            _container = null;
        }

        [Test]
        public void when_ctor_called_then_it_should_create_a_simple_container()
        {
            Assert.That(_sut.Container, Is.InstanceOf(typeof(SimpleContainer)));
        }

        [Test]
        public void when_build_called_then_it_should_register_container_in_container()
        {
            ConfigureContainer.Set(_container.Object, _sut);
            _sut.Build();
            _container.Verify(
                x => x.RegisterAsSingleton(It.Is<IContainer>(x1 => _container.Object.Equals(_sut.Container))),
                Times.Once());
        }

        public void when_build_called__then_it_should_register_and_call_all_default_component_configurators()
        {
            ConfigureContainer.Set(_container.Object, _sut);

        }
    }
    // ReSharper restore InconsistentNaming
}