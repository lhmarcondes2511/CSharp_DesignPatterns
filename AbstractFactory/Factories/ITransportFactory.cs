using AbstractFactory.Aircrafts;
using AbstractFactory.LandVehicles;
using AbstractFactory.Lime;

namespace AbstractFactory.Factories
{
    interface ITransportFactory
    {
        IAircraft CreateTransportAircraft();
        ILandVehicle CreateTransportLandVehicle();
    }
}
