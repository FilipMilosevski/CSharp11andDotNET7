﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public class Truck : Vehicle
    {
        private const double ACConsumption = 1.6;
        private const double UsedFuel = 95;
        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
        }
        public override void Drive(double distance)
        {
            double neededFuel = distance * (base.FuelConsumption + ACConsumption);
            if (neededFuel <= base.FuelQuantity)
            {
                base.FuelQuantity -= neededFuel;
                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine($"Truck needs refueling");
            }
        }
        public override double Refuel(double liters)
        {
            return base.FuelQuantity += (liters * UsedFuel / 100.0);
        }
    }
}


