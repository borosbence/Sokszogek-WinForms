using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Repositories
{
    public interface ISokszogRepository
    {
        IList<string> GetSokszogek();
        string GetNameByIndex(int index);
    }
}
