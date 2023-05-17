using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem.Vehicles
{
    public class Bus : Vehicle
    {
        public bool Toalet { get; set; }
        public Bus() : base() { }

        public Bus(bool toalet, string model, int productionYear, Person owner, int weight, int width, int fuelType, int passengersNo) : base(model, productionYear, owner, weight, width, fuelType, passengersNo)
        {
            Toalet = toalet;
        }
        public override int isEconomic()
        {
            return base.isEconomic();
        }
    }
}
