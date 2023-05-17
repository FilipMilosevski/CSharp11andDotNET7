using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1.Vehicles
{
    public class Bus : Vehicle
    {
        public bool Toalet { get; set; }
        public Bus() : base() { }

        public Bus(bool toalet, string model, int productionYear, Person owner, int weight, int width, int fuelType, int passengerNo) : base(model, productionYear, owner, weight, width, fuelType, passengerNo)
        {
            Toalet = toalet;
        }
        public override int isEconomic()
        {
            return base.isEconomic();
        }
    }
}
