using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.ViewInterfaces
{
    interface INegyzetView
    {
        string oldalA { get; }
        string errorOldalA { get; set; }
    }
}
