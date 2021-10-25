using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Middlewares
{
    class CheckPasswordMiddleware : Middleware
    {
        public override bool Check(string email, string password)
        {
            if (password.Equals("123456"))
            {
                Console.WriteLine("Senha fraca, Para sua segurança, troque-a");
                return true;
            }

            Console.WriteLine("Seja bem vindo");
            return CheckNext(email, password);
        }
    }
}
