using FactoryMethod.Vehicles;

namespace FactoryMethod.Factories
{
    class CycleTransport : Transport
    {
        protected override IVehicle CreateTransport()
        {
            return new Cycle();
        }
    }
}
