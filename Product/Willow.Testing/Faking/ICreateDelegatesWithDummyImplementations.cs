using System;

namespace Willow.Testing.Faking
{
    public interface ICreateFakeDelegates
    {
        object generate_delegate_for(Type delegate_type);
    }
}