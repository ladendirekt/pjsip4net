using NUnit.Framework;
using pjsip4net.Core.Container;

namespace pjsip4net.Tests
{
    // ReSharper disable InconsistentNaming
    [TestFixture]
    public class given_a_simple_container
    {
        private SimpleContainer _sut;

        public interface Interfaze
        { }
        
        public interface Interfaze1
        { }

        public class Clazz : Interfaze
        { }

        public class Clazz1 : Interfaze1
        {
            public Clazz1(Interfaze dependency)
            { }
        }

        [SetUp]
        public void TestSetup()
        {
            _sut = new SimpleContainer();
        }

        [TearDown]
        public void Teardown()
        {
            _sut = null;
        }

       //todo: write tests for equal interfaces being registered in different combinations 
        //(unnamed transients[throws], unnamed singletons[throws], unnamed transient & singleton [throws], 
        //reversed [throws], one named & the other is not [does not throw in different combinations]
        
        [Test]
        public void when_one_transient_configuration_without_dependencies_registered_then_resolves_type_correctly()
        {
            _sut.Register<Interfaze, Clazz>();
            Assert.That(_sut.Get<Interfaze>(), Is.InstanceOf(typeof(Clazz)));
        }
        
        [Test]
        public void when_two_transient_configurations_with_dependency_registered_then_resolves_type_correctly()
        {
            _sut.Register<Interfaze, Clazz>();
            _sut.Register<Interfaze1, Clazz1>();
            Assert.That(_sut.Get<Interfaze1>(), Is.InstanceOf(typeof(Clazz1)));
        }
        
        [Test]
        public void when_one_transient_configuration_with_singleton_dependency_candidate_registered_then_resolves_type_correctly()
        {
            _sut.RegisterAsSingleton<Interfaze, Clazz>();
            _sut.Register<Interfaze1, Clazz1>();
            Assert.That(_sut.Get<Interfaze1>(), Is.InstanceOf(typeof(Clazz1)));
        }
        
        [Test]
        public void when_one_singleton_configuration_with_transient_dependency_candidate_registered_then_resolves_type_correctly()
        {
            _sut.Register<Interfaze, Clazz>();
            _sut.RegisterAsSingleton<Interfaze1, Clazz1>();
            Assert.That(_sut.Get<Interfaze1>(), Is.InstanceOf(typeof(Clazz1)));
        }
        
        [Test]
        public void when_one_transient_configuration_with_transient_named_dependency_candidate_registered_then_resolves_type_correctly()
        {
            _sut.Register<Interfaze, Clazz>("1");
            _sut.Register<Interfaze1, Clazz1>();
            Assert.That(_sut.Get<Interfaze1>(), Is.InstanceOf(typeof(Clazz1)));
        }
        
        [Test]
        public void when_one_transient_configuration_with_two_transient_and_named_dependency_candidates_registered_then_resolves_type_correctly()
        {
            _sut.Register<Interfaze, Clazz>();
            _sut.Register<Interfaze, Clazz>("1");
            _sut.Register<Interfaze1, Clazz1>();
            Assert.That(_sut.Get<Interfaze1>(), Is.InstanceOf(typeof(Clazz1)));
        }
    }
    // ReSharper restore InconsistentNaming
}