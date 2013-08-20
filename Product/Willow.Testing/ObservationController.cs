using Willow.Testing.Core;
using Willow.Testing.Faking;

namespace Willow.Testing
{
    public interface ObservationController<Class> 
        : IConfigureSpecifications
        where Class : class
    {
        Class run_setup();
        void run_tear_down();

        ICreateFakes fake { get; }
        IProvideDependencies depends { get; }
        SUTFactory<Class> sut_factory { get; }
        TestStateFor<Class> test_state { get; }
    }
}