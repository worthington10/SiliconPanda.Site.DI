using SiliconPanda.DI.Core;

namespace SiliconPanda.DI.Implementation
{
    public class Job : IJobActivator, IJobRegister
    {
        public T CreateInstance<T>()
        {
            throw new System.NotImplementedException();
        }

        public T RegisterInstance<T>(T register)
        {
            throw new System.NotImplementedException();
        }
    }
}
