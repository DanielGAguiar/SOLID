using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicle
{
    interface IVehicles
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
        void ConfigureMotocicle(string color, int year, double engine);

        void StartVehicle();
    }
}
