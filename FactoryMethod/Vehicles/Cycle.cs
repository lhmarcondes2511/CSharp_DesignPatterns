using System;

namespace FactoryMethod.Vehicles
{
    class Cycle : IVehicle
    { 
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os lanches!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Iniciamos a corrida.");
        }
    }
}
