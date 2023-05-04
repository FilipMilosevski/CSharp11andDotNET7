using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingSystem
{
    public class Vehicle
    {
        public string Model { get; set; }
        public int ProductionYear { get; set; }
        public Person Owner { get; set; }
        public int Weight { get; set; }
        public int Width { get; set; }
        public string FuelType { get; set; }
        public int PassengersNo { get; set; }

    }
}
