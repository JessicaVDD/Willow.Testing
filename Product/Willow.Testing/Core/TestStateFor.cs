namespace Willow.Testing.Core
{
    public interface TestStateFor<SUT> : 
        IConfigureTheSut<SUT>, IConfigureTheTestStateFor<SUT>, IConfigureSetupPairs
    {
    }
}