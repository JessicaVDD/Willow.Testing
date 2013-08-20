using Willow.Testing.Faking;

namespace Willow.Testing.Core.Factories
{
    public interface ICreateTheDependencyRegistry
    {
        IManageTheDependenciesForASUT create(IManageFakes fakes_gateway,
                                             IResolveADependencyForTheSUT dependency_resolver);
    }
    public class DependencyRegistryFactory:ICreateTheDependencyRegistry
    {
        public IManageTheDependenciesForASUT create(IManageFakes fakes_gateway, IResolveADependencyForTheSUT dependency_resolver)
        {
            return new DependenciesRegistry(dependency_resolver, fakes_gateway);
        }
    }
}