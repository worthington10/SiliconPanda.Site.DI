using System;
using System.Reflection;
using Autofac;
using SiliconPanda.DI.Core;

namespace SiliconPanda.DI.Implementation
{
    public class Job : IJobActivator, IJobRegister
    {
        private readonly ContainerBuilder _container;

        public Job(ContainerBuilder container)
        {
            _container = container;
        }

        public T CreateInstance<T>()
        {
            throw new NotImplementedException();
        }
        
        public void RegisterInstance<T>(T register)
        {
            throw new NotImplementedException();
        }

        public void RegisteInstanceByInterfaceAndAssemnly(Type interfaceInstaller, string assemblyName)
        {
            var assembly = Assembly.Load(assemblyName);

            _container
                .RegisterAssemblyTypes(assembly)
                .AssignableTo(interfaceInstaller)
                .AsImplementedInterfaces()
                .InstancePerRequest();
        }

        public void Build()
        {
            _container.Build();
        }
    }
}
