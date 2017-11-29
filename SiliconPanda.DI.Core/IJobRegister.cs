namespace SiliconPanda.DI.Core
{
    public interface IJobRegister
    {
        T RegisterInstance<T>(T register);
    }
}
