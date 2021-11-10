using System;

namespace Ocp.Vehicles
{
    class Vehicle : IVehicle
    {
        protected string _color;
        protected int _year;
        protected double _engine;

        public Vehicle(string color, int year, double engine)
        {
            this._color = color;
            this._year = year;
            this._engine = engine;           
        }

        //Caso este método seja modificado nas subclasses ele poderia tornar-se virtual
        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores");
        }
    }
}
