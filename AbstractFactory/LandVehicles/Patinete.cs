using AbstractFactory.LandVehicles;
using System;

namespace AbstractFactory.Lime
{
    class Patinete : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegando o seu lanche");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciando a corrida.");
        }
    }
}
