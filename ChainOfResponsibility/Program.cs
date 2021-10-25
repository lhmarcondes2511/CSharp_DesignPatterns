using ChainOfResponsibility.Middlewares;
using ChainOfResponsibility.Servers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    class Program
    {
        private static Server server;
        static void Init()
        {
            server = new Server();

            server.RegisterUser("master@hcode.com.br", "123456789");
        
            server.RegisterUser("user@hcode.com.br", "123456");

            Middleware middleware = new CheckUserMiddleware(server);

            middleware.LinkWith(new CheckPermissionMiddleware());
            middleware.LinkWith(new CheckPasswordMiddleware());

            server.SetMiddleware(middleware);
        }
        static void Main(string[] args)
        {
            Init();

            Boolean done = false;

            do
            {
                Console.WriteLine("Digite seu email");
                string email = Console.ReadLine();

                Console.WriteLine("Digite sua senha");
                string password = Console.ReadLine();

                done = server.Login(email, password);


            } while (!done);

            Console.ReadLine();
        }
    }
}
