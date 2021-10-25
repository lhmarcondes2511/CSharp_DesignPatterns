using AbstractFactory.App;
using AbstractFactory.Factories;
using System;

namespace AbstractFactory
{
    class Program
    {
        static Application ConfigureApplication()
        {
            Application app;

            ITransportFactory transportFactory;
            string company = "lime";

            if (company == "uber")
            {
                transportFactory = new UberTransport();
            } else if (company == "lime") 
            {
                transportFactory = new LimeTransport();
            } else
            {
                transportFactory = new NineNIneTransport();
            }

            app = new Application(transportFactory);

            return app;
        }
        static void Main(string[] args)
        {
            Application app = ConfigureApplication();

            app.StartRoute();


            Console.ReadLine();
        }
    }
}
