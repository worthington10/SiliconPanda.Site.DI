using System;

namespace SiliconPanda.DI.Core
{
    public interface IJobRegister
    {
        void RegisterInstance<T>(T register);

        void RegisteInstanceByInterfaceAndAssemnly(Type interfaceInstaller, string assembly);

        void Build();
    }
}
