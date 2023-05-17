using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public abstract class V
    {
        private double potrosnjaGorivo;
        private double kapacitetGorivo;

        protected V(double potrosnjaGorivo, double kapacitetGorivo)
        {
            this.potrosnjaGorivo = potrosnjaGorivo;
            this.kapacitetGorivo = kapacitetGorivo;
        }
        public double PotrosnjaGorivo
        {
            get { return this.potrosnjaGorivo; }
            set { this.potrosnjaGorivo = value; }
        }
        public double KapacitetGorivo
        {
            get { return this.kapacitetGorivo; }
            set { this.kapacitetGorivo = value; }
        }
        public abstract void Vozi(double distance);
        public abstract double Polni(double liters);
        public override string ToString()
        {
            return $"{this.GetType().Name} : {this.kapacitetGorivo:F2}";
        }
    }

    


}
