namespace Willow.Testing.Core
{
    public interface IConfigureTheSut<Contract>
    {
        void run(SUTContextSetup<Contract> action);
    }
}