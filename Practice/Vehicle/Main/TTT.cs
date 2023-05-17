using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class TTT : V
    {
        private const double ACConsumption = 1.6;
        private const double UsedFuel = 95;

        public TTT(double kapacitetGorivo, double potrosnjaGorivo) : base(potrosnjaGorivo, kapacitetGorivo)
        {

        }
        public override void Vozi(double distance) {
            double needFuel = distance * (base.PotrosnjaGorivo + ACConsumption);
            if (needFuel < base.KapacitetGorivo) 
            {
                base.KapacitetGorivo -= needFuel;
                Console.WriteLine($"Kamionot vozese {distance} kilometri");
            }
            else
            {
                Console.WriteLine("Vo kamionot treba da se natoci gorivo");
            }

        }
        public override double Polni(double liters)
        {
            return base.KapacitetGorivo += (liters * UsedFuel / 100.0);
        }


    }
}
