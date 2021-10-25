using System;
namespace AbstractFactory.LandVehicles
{
    class Car : ILandVehicle
    {
        public void GetCargo()
        {
            Console.WriteLine("Pegamos os passageiros, estamos prontos!");
        }

        public void StartRoute()
        {
            GetCargo();
            Console.WriteLine("Inicianod o trajeto.");
        }
    }
}
