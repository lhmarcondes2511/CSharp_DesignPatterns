using Adapter.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Adapter.Controller
{
    class MercadoPago : IMercadoPago
    {
        private Token token;
        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento pelo mercado pago");
        }

        public void SendPaymentMercadoPago()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento pelo mercado pago");
        }
    }
}
