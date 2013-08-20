using System;

namespace Willow.Testing.Core
{
    public interface IConfigureSetupPairs
    {
        void add_setup_teardown_pair(ObservationPair observation_pair);
        void add_setup_teardown_pair(Action context, Action teardown);
    }
}