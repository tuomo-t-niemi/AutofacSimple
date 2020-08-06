using Autofac;
using BusinessLogicLibrary;
using DataAcquisitionLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutofacSimple
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Application>().As<IApplication>();
            builder.RegisterType<BusenessLogic>().As<IBusenessLogic>();

            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataAcquisitionLibrary)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(DataAnalysisLibrary)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));
            builder.RegisterAssemblyTypes(Assembly.Load(nameof(UtilitiesLibrary)))
                .As(t => t.GetInterfaces().FirstOrDefault(i => i.Name == "I" + t.Name));

            return builder.Build();
        }
    }
}
