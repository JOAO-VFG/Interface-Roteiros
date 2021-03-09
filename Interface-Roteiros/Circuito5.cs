using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Roteiros
{
    class Circuito5
    {
        public Double Rth { get; set; }
        public Double fonte { get; set; }
        public Double r1 { get; set; }
        public Double r2 { get; set; }
        public Double r3 { get; set; }
        public Double i1 { get; set; }
        public Double i2 { get; set; }
        public Double i3 { get; set; }
        public Double p1 { get; set; }
        public Double p2 { get; set; }
        public Double p3 { get; set; }
        public Double Vth { get; set; }
        public Double i { get; set; }

        public void CalculaCircuito()
        { 
            Rth = r1 + r2;
            i = Vth / (Rth + r3);
        }
        public void CalculaCorrentes()
        {
            i1 = fonte / r1;
            i2 = fonte / r2;
            i3 = fonte / r3;
        }
        public void CalculaPotencia()
        {
            p1 = fonte * i1;
            p2 = fonte * i2;
            p3 = fonte * i3;
        }
    }
}
