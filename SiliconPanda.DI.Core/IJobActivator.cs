namespace SiliconPanda.DI.Core
{
    public interface IJobActivator
    {
        T CreateInstance<T>();
    }
}
