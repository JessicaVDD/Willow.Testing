using System;

namespace Willow.Testing.Faking
{
    public interface IResolveADependencyForTheSUT
    {
        object resolve(Type item);
    }
}