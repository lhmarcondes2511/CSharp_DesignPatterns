using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;
using AbstractFactory.Lime;

namespace AbstractFactory.Factories
{
    class LimeTransport : ITransportFactory
    {
        public IAircraft CreateTransportAircraft()
        {
            return new Drone();
        }

        public ILandVehicle CreateTransportLandVehicle()
        {
            return new Patinete();
        }
    }
}
