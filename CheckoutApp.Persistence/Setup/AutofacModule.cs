using System.Reflection;
using Autofac;
using Module = Autofac.Module;

namespace CheckoutApp.Persistence.Setup
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Scans assembly for public classes
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            base.Load(builder);
        }
    }
}