using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Haromszog : Sokszog
    {
        public double oldalC { get; set; }
        public Haromszog(string A, string B, string C) : base(A, B)
        {
            oldalC = Convert.ToDouble(C);
        }

        public override double Kerulet()
        {
            return oldalA + oldalB + oldalC;
        }

        public override double Terulet()
        {
            // Hérón képlet
            // https://hu.wikipedia.org/wiki/H%C3%A9r%C3%B3n-k%C3%A9plet
            double s = (oldalA + oldalB + oldalC) / 2;
            var terulet = Math.Sqrt(s * (s - oldalA) * (s - oldalB) * (s - oldalC));
            return terulet;
        }
    }
}
