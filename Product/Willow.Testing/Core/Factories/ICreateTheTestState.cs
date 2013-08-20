using Willow.Testing.Faking;

namespace Willow.Testing.Core.Factories
{
    public interface ICreateTheTestState
    {
        TestStateFor<SUT> create_for<SUT>(ICreateAndManageDependenciesFor<SUT> sut_factory) where SUT : class;
    }

    public class TestStateFactory : ICreateTheTestState
    {
        public TestStateFor<SUT> create_for<SUT>(ICreateAndManageDependenciesFor<SUT> sut_factory) where SUT : class
        {
            return new DefaultTestStateFor<SUT>(sut_factory);
        }
    }
}