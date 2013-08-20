namespace Willow.Testing.Core
{
    public interface IConfigureTheTestStateFor<Class>
    {
        Class run_setup();
        void run_tear_down();
    }
}