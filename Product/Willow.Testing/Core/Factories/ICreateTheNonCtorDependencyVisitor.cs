using Willow.Testing.Faking;

namespace Willow.Testing.Core.Factories
{
    public interface ICreateTheNonCtorDependencyVisitor
    {
        IUpdateNonCtorDependenciesOnAnItem create(IManageTheDependenciesForASUT dependency_registry);
    }

    public class NonCtorDependencyVisitorFactory : ICreateTheNonCtorDependencyVisitor
    {
        public IUpdateNonCtorDependenciesOnAnItem create(IManageTheDependenciesForASUT dependency_registry)
        {
            return new NonCtorDependencySetter(dependency_registry);
        }
    }
}