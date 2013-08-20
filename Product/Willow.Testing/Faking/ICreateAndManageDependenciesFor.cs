using Willow.Testing.Core;

namespace Willow.Testing.Faking
{
    public interface ICreateAndManageDependenciesFor<Class> : SUTFactory<Class>,
                                                                    IProvideDependencies,ICreateThe<Class>
    {
        
    }
}