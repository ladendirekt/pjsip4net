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
    }
    // ReSharper restore InconsistentNaming
}