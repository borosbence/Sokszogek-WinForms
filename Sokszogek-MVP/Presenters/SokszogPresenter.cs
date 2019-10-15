using Sokszogek_MVP.Repositories;
using Sokszogek_MVP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek_MVP.Presenters
{
    public class SokszogPresenter
    {
        private ISokszogView sokszogView;
        private ISokszogRepository sokszogRepo;

        public SokszogPresenter(ISokszogView sokszogV)
        {
            sokszogView = sokszogV;
            sokszogRepo = new SokszogRepository();
        }

        public void LoadData()
        {
            sokszogView.SokszogList = sokszogRepo.GetSokszogek();
        }
    }
}
