using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Car : Vehicle
    {
        private const double ACConsumption = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            double needFuel = distance * (base.FuelConsumption + ACConsumption);
            if (needFuel <= base.FuelQuantity)
            {
                base.FuelQuantity -= needFuel;
                Console.WriteLine($"Car travelled {distance}");
            }
            else
            {
                Console.WriteLine($"Car needs refueling");
            }
        }

        public override double Refuel(double liters)
        {
            return base.FuelQuantity += liters;
        }
    }
}


