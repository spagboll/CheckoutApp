using System;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using CheckoutApp.Application.Queries;
using CheckoutApp.Ioc;
using MediatR;

namespace CheckoutApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {            
            var container = new IoC().ConfigureIoc();

            var mediator = container.Resolve<IMediator>();

            var result = await mediator.Send(new GetProductsQuery());

            result.ToList().ForEach(x => Console.WriteLine(x.Sku));

            var result2 = await mediator.Send(new GetProductBySkuQuery("CHEESE"));

            Console.Write(result2.Sku);

            Console.ReadLine();
        }
    }
}
