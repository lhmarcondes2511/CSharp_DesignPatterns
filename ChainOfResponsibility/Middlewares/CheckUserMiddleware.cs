using ChainOfResponsibility.Servers;
using System;

namespace ChainOfResponsibility.Middlewares
{
    class CheckUserMiddleware : Middleware
    {
        private Server server;

        public CheckUserMiddleware(Server server)
        {
            this.server = server;
        }

        public override bool Check(string email, string password)
        {
            if (!server.HasEmail(email))
            {
                Console.WriteLine("Email invalido!");
                return false;
            }

            if (!server.IsValidPassword(email, password))
            {
                Console.WriteLine("Email e/ou senha incorreta");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
