using Machine.Fakes;
using Machine.Fakes.Sdk;
using Willow.Testing.Faking;

namespace Willow.Testing.Core.Factories
{
    public interface ICreateTheFakesGateway
    {
        IManageFakes create<Class, Engine>() where Class : class where Engine : IFakeEngine, new();
    }
    public class FakeGatewayFactory : ICreateTheFakesGateway
    {
        public IManageFakes create<Class, Engine>() where Class : class where Engine : IFakeEngine, new()
        {
            return new FakesAdapter(new SpecificationController<Class>(new Engine()));
        }
    }
}