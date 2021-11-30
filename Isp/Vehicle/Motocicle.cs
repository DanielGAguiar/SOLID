using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicle
{
    class Motocicle : IVehicles
    {
        private string _color;
        private int _year;
        private double _engine;
        
        public Motocicle(string color, int year, double engine)
        {
            ConfigureMotocicle(color, year, engine);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
           
        }

        public void ConfigureMotocicle(string color, int year, double engine)
        {
            this._color = color;
            this._year = year;
            this._engine = engine;


            Console.WriteLine($"Criando uma moto ano {year}, {engine} cilindradas e da cor {color}");
            StartVehicle();
        }
        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores!");
        }
    }
}
