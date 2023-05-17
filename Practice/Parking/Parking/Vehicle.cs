﻿using System;
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
        public int FuelType { get; set; }
        public int PassengersNo { get; set; }
        public Vehicle()
        {

        }

        public Vehicle(string model, int productionYear, Person owner, int weight, int width, int fuelType, int passengersNo)
        {
            Model = model;
            ProductionYear = productionYear;
            Owner = owner;
            Weight = weight;
            Width = width;
            FuelType = fuelType;
            PassengersNo = passengersNo;
        }
        public int getWidth()
        {
            return Width;
        }
        public int getWeight()
        {
            return Weight;
        }
        public virtual int isEconomic()
        {
            if (FuelType.Equals("electricity"))
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

    }
}
