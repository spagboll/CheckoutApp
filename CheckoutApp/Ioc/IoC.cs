using System.Reflection;
using Autofac;

namespace CheckoutApp.Ioc
{
    public class IoC
    {
        public IContainer ConfigureIoc()
        {
            var builder = new ContainerBuilder();

            builder.RegisterAssemblyModules(Assembly.GetAssembly(typeof(Application.Setup.AutofacModule)));
            builder.RegisterAssemblyModules(Assembly.GetAssembly(typeof(Persistence.Setup.AutofacModule)));
            
            return builder.Build();
        }
    }
}