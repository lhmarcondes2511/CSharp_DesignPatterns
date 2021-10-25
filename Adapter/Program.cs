using Adapter.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {

            //Paypal payment = new Paypal();
            //Payonner payment = new Payonner();

            //IPaypalPayment payment = new PayonnerAdapter(new Payonner());
            IPaypalPayment payment = new MercadoPagoAdapter(new MercadoPago());
            payment.PaypalPayment();
            payment.PaypalReceive();

            //payment.SendPayment();
            //payment.ReceivePayment();
            Console.ReadLine();
        }
    }
}
