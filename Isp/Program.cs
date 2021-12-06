using Isp.Vehicle;
using System;


namespace Isp
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Verde", 2015, 1.8, 7, 4);
            Motocicle moto = new Motocicle("Rosa", 2018, 250);

            Console.ReadLine();
        }
    }
}
