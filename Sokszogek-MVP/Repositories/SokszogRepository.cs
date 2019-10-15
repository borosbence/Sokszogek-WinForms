using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Repositories
{
    public class SokszogRepository : ISokszogRepository
    {
        public IList<string> GetSokszogek()
        {
            List<string> sokszogek = new List<string>
            {
                "--Kérem válasszon--",
                "Téglalap",
                "Háromszög",
                "Négyzet"
            };
            return sokszogek;
        }

        public string GetNameByIndex(int index)
        {
            return GetSokszogek().ElementAt(index);
        }
    }
}
