using Builder.Builders;
using Builder.Directors;
using Builder.Products;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder builder = new VehicleBuilder();
            Director director = new Director(builder);

            director.ConstructSuv();

            Vehicle suv = builder.GetVehicle();

            Console.WriteLine($"Criado um veiculo do tipo: {suv.VehicleType} e airbag: {suv.Airbag}");

            Console.ReadLine();
        }
    }
}
