using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Repositories
{
    class SokszogRepo
    {
        public List<string> GetSokszogek()
        {
            List<string> sokszogek = new List<string> 
            {
                "-- Kérem válasszon --",
                "Négyzet",
                "Téglalap",               
                "Háromszög"
            };
            return sokszogek;
        }

        public string GetNameByIndex(int index)
        {
            return GetSokszogek().ElementAt(index);
        }
    }
}
