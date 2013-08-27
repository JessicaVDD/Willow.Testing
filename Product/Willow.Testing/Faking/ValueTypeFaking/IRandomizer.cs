using System;

namespace Willow.Testing.Faking.ValueTypeFaking
{
    public interface IRandomizer<out T>
    {
        T Next();
    }
}