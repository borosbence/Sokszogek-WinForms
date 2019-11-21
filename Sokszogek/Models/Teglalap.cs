using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Models
{
    public class Teglalap : Sokszog
    {
        // CTOR + TAB + TAB
        public Teglalap(double A, double B): base(A, B)
        {

        }

        public override double Kerulet()
        {
            return 2 * (oldalA + oldalB);
        }

        public override double Terulet()
        {
            return oldalA * oldalB;
        }
    }
}
