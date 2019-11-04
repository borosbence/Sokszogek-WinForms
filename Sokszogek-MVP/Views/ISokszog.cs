using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Views
{
    public interface ISokszogView
    {
        string oldalA { get; set; }
        string oldalB { get; set; }
        string Kerulet { get; set; }
        string Terulet { get; set; }
        IList<string> SokszogList { get; set; }
    }
}
