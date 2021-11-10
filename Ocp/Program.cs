using Ocp.Vehicles;
using System;

namespace Ocp
{
    class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.Car;

            if (type == TypeVehicle.Car)
            {
                Car vehicle = new Car("Prata", 2019, 2.0, 5, 4);
                
            }
            else
            {
                Motocyclecs vehicle = new Motocyclecs("Branca", 2020, 250);
                
            }

            Console.ReadLine();
        }
    }
}
