using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicle
{
    class Car : IVehicles
    {
        private string _color;
        private int _year;
        private double _engine;
        private int _seats;
        private int _doors;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar( color, year, engine, seats, doors);
        }
        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this._color = color;
            this._year = year;
            this._engine = engine;
            this._seats = seats;
            this._doors = doors;

            Console.WriteLine($"Criando um carro ano {year}, motor {engine}, da cor {color}, {seats} acentos e {doors} portas");
            StartVehicle();
        }

        public void ConfigureMotocicle(string color, int year, double engine)
        {
           
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
