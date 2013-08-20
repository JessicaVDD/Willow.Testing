using Machine.Fakes;
using Machine.Specifications;
using Willow.Testing.Core;
using Willow.Testing.Extensions;
using Willow.Testing.Faking;

namespace Willow.Testing.Observations
{
    public abstract class InstanceObservations<Contract, Class, Engine> : CoreObservations<Contract, Class, Engine>
        where Contract : class where Class : class, Contract where Engine : IFakeEngine, new()
    {
        protected static Contract sut;

        Because base_because = () => { sut = controller.run_setup(); };

        protected static Class concrete_sut
        {
            get { return sut.downcast_to<Class>(); }
        }

        protected static IProvideDependencies depends
        {
            get { return controller.depends; }
        }

        protected static SUTFactory<Class> sut_factory
        {
            get { return controller.sut_factory; }
        }

        protected static IConfigureTheSut<Class> sut_setup
        {
            get { return controller.test_state; }
        }
    }
}