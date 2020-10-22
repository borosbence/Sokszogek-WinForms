using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.ViewInterfaces
{
    interface IHaromszogView : ITeglalapView
    {
        string oldalC { get; }
        string errorOldalC { get; set; }
    }
}
