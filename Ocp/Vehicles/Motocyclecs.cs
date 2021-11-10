using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    class Motocyclecs: Vehicle
    {     

        public Motocyclecs(string color, int year, double engine) : base(color, year, engine)
        {
            ConfigureMotocyclecs();
        }

        public void ConfigureMotocyclecs()
        {
            Console.WriteLine($"Criando uma moto {_color}, {_year}, {_engine} cilindradas.");
            StartVehicle();
        } 
    }
}
