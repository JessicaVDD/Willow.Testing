using System;

namespace Willow.Testing.Faking
{
    public interface SUTFactory<SUT>
    {
        void create_using(Func<SUT> factory);
    }
}