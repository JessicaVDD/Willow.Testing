using Machine.Fakes;
using Machine.Specifications;

namespace Willow.Testing.Observations
{
    public class StaticObservations<Engine> : CoreObservations<object, object, Engine> where Engine : IFakeEngine, new()
    {
        Because base_because = () => controller.run_setup();
    }
}