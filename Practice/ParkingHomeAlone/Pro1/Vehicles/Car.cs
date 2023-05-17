using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1.Vehicles
{
    public class Car : Vehicle
    {
        public string TypeCar { get; set; }
        public Car() { }

        public Car(string typeCar, string model, int productionYear, Person owner, int weight, int width, int fuelType, int passengerNo) : base(model, productionYear, owner, weight, width, fuelType, passengerNo)
        {
            TypeCar = typeCar;
        }
        public override int isEconomic()
        {
            return base.isEconomic();
        }
    }
}
