using AbstractFactory.Aircrafts;
using System;

namespace AbstractFactory.Lime
{
    class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Checando os ventos norte. Tudo ok!");
        }

        public void GetCargo()
        {
            Console.WriteLine("preparando para subir");
        }

        public void StartRoute()
        {
            CheckWind();
            GetCargo();
            Console.WriteLine("Iniciando a decolagem.");
        }
    }
}
