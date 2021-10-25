using Adapter.Interfaces;
using System;

namespace Adapter.Controller
{
    class MercadoPagoAdapter : IPaypalPayment
    {
        private MercadoPago mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return this.mercadoPago.AuthToken();
        }

        public void PaypalPayment()
        {
            this.mercadoPago.SendPaymentMercadoPago();
        }

        public void PaypalReceive()
        {
            this.mercadoPago.ReceivePaymentMercadoPago();
        }
    }
}
