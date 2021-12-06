
namespace Isp.Vehicle
{
    interface IVehicleCar : IVehicles
    {
        void ConfigureCar(string color, int year, double engine, int seats, int doors);
    }
}
