using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle
{
    public abstract class Vehicle
    {
        //private access modfier - kodot ima pristap samo vo ista klasa
        private double fuelQuantity;
        private double fuelConsumption;
        //protected access modfier - kodot ima pristap vo ista klasa ili vo klasa koja nasleduva od taa klasa
        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            this.fuelQuantity = fuelQuantity;
            this.fuelConsumption = fuelConsumption;
        }
        public double FuelConsumption
        {
            get { return this.fuelConsumption; }
            set { this.fuelConsumption = value; }
        }
        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }
        public abstract void Drive(double distance);
        public abstract double Refuel(double liters);
        public override string ToString()
        {
            return $"{this.GetType().Name}:{this.fuelQuantity:F2}";
        }
    }
}
