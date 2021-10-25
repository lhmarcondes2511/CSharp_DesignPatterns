using System;

namespace Bridge.Platforms
{
    class Youtube : IPlatform
    {

        public Youtube()
        {
            ConfigureRMTP();
            Console.WriteLine("Youtube: Transmissão iniciada");
        }

        public void AuthToken()
        {
            Console.WriteLine("Youtube: Autorizando aplicação");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("Youtube: Configurando servidor RMTP");
        }
    }
}
