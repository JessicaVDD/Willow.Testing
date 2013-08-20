using System;

namespace Willow.Testing.Core
{
    public interface ICreateFakes
    {
        InterfaceType an<InterfaceType>() where InterfaceType : class;
        object an(Type type);
    }
}