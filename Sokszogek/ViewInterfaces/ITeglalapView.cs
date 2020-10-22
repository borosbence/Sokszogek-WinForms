using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.ViewInterfaces
{
    interface ITeglalapView : INegyzetView
    {
        string oldalB { get; }
        string errorOldalB { get; set; }
    }
}
