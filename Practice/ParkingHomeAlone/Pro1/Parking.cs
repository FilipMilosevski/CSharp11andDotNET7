using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro1
{
    public class Parking
    {
        public int ParkingId {get;set;}
        public int ParkingSpaceNumber{get;set;}
        public string Address {get;set;}
        public string City {get;set;}
        public int PricePerHour{get;set;}
        public int Discount{get;set;}
        public string FreeDays{get;set;}
        public Company OwnerCompany{get;set;}

        public List<VehicleInfo> VehicleInfos { get; set; } = new List<VehicleInfo>();

        public Parking() { }

        public Parking(int parkingId, int parkingSpaceNumber, string address, string city, int pricePerHour, int discount, string freeDays, Company ownerCompany, List<VehicleInfo> vehicleInfos)
        {
            ParkingId = parkingId;
            ParkingSpaceNumber = parkingSpaceNumber;
            Address = address;
            City = city;
            PricePerHour = pricePerHour;
            Discount = discount;
            FreeDays = freeDays;
            OwnerCompany = ownerCompany;
            VehicleInfos = vehicleInfos;
        }
    }
}
