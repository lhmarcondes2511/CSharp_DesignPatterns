namespace Adapter.Interfaces
{
    interface IMercadoPago
    {
        Token AuthToken();
        void ReceivePaymentMercadoPago();
        void SendPaymentMercadoPago();
    }
}
