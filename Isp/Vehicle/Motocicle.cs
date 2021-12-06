using System;


namespace Isp.Vehicle
{
    class Motocicle : IVehicleMotoCycle
    {
        private string _color;
        private int _year;
        private double _engine;
        
        public Motocicle(string color, int year, double engine)
        {
            ConfigureMotocicle(color, year, engine);
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
