using System.Reflection;
using Autofac;
using MediatR.Extensions.Autofac.DependencyInjection;
using Module = Autofac.Module;

namespace CheckoutApp.Application.Setup
{
    public class AutofacModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //Scans assembly for public classes
            builder.RegisterAssemblyTypes(Assembly.GetExecutingAssembly()).AsImplementedInterfaces();

            builder.RegisterMediatR(Assembly.GetExecutingAssembly());

            base.Load(builder);
        }
    }
}