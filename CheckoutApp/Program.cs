using System;
using CheckoutApp.Ioc;

namespace CheckoutApp
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var container = new IoC().ConfigureIoc();
            
            
            
            Console.WriteLine("Hello World!");
        }
    }
}
