using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class CCC : V
    {
        private const double ACConsumption = 0.9;

        public CCC(double kapacitetGorivo, double potrosnjaGorivo) : base(potrosnjaGorivo, kapacitetGorivo)
        {

        }
        public override void Vozi(double distance)
        {
            double needFuel = distance * (base.PotrosnjaGorivo + ACConsumption);
            if (needFuel <= base.KapacitetGorivo)
            {
                base.KapacitetGorivo -= needFuel;
                Console.WriteLine($"Kolata izvoze {distance} kilometri");
            }
            else
            {
                Console.WriteLine($"Vo kolata treba da se natoci gorivo");
            }
        }

        public override double Polni(double liters)
        {
            return base.KapacitetGorivo += liters;
        }


    }
}
