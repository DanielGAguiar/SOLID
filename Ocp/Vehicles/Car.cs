 using System;

namespace Ocp.Vehicles
{
    class Car: Vehicle
    {
        private int _seats;
        private int _doors;

        public Car(string color, int year, double engine, int seats, int doors):base (color, year, engine)
        {
            this._seats = seats;
            this._doors = doors;
            ConfigureCar();
        }

        public void ConfigureCar()
        {
             Console.WriteLine($"Criando um carro {_color}, {_year}, motor {_engine}.0, {_seats} lugares e {_doors} portas.");
             StartVehicle();
        }
    }
}
