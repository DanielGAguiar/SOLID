using Isp.Vehicle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Prata", 2020, 1.6, 5, 4);
            Motocicle moto = new Motocicle("Preta", 2019, 250);

            Console.ReadLine();
        }
    }
}
