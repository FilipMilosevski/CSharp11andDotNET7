using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1.Vehicles
{
    public class Lorry : Vehicle
    {
        public int Capacity { get; set; }
        public Lorry() : base() { }

        public Lorry(int capacity, string model, int productionYear, Person owner, int weight, int width, int fuelType, int passengerNo) : base(model, productionYear, owner, weight, width, fuelType, passengerNo)
        {
            Capacity = capacity;
        }
        public override int isEconomic()
        {
            return base.isEconomic();
        }
    }
}
