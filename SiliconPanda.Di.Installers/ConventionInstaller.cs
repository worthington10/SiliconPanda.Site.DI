using SiliconPanda.DI.Core;
using SiliconPanda.Shared.Core.Convention;

namespace SiliconPanda.Di.Installers
{
    public static class ConventionInstaller
    {
        public static void RegisterManagers(this IJobRegister wrapper, string assemblyName)
        {
            wrapper.RegisteInstanceByInterfaceAndAssemnly(typeof(IManager), assemblyName);
        }
        public static void RegisterFactory(this IJobRegister wrapper, string assemblyName)
        {
            wrapper.RegisteInstanceByInterfaceAndAssemnly(typeof(IFactory), assemblyName);
        }
        public static void RegisterConfiguration(this IJobRegister wrapper, string assemblyName)
        {
            wrapper.RegisteInstanceByInterfaceAndAssemnly(typeof(IConfiguration), assemblyName);
        }
    }
}
