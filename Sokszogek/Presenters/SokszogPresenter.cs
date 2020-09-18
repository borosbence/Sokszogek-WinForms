using Sokszogek.Models;
using Sokszogek.Repositories;
using Sokszogek.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Presenters
{
    public class SokszogPresenter
    {
        private ISokszogView sokszogView;
        private IHaromszog haromszogView;
        private SokszogRepository sokszogRepo = new SokszogRepository();
        private string sokszogNev { get; set; }
        public bool oldalCLetezik { get; set; }

        public SokszogPresenter(ISokszogView sokszogV, IHaromszog haromszogV)
        {
            sokszogView = sokszogV;
            haromszogView = haromszogV;
            sokszogRepo = new SokszogRepository();
        }

        public void LoadData()
        {
            sokszogView.SokszogList = sokszogRepo.GetSokszogek();
        }

        public void ShowOldal(int index)
        {
            sokszogNev = sokszogRepo.GetNameByIndex(index);
            switch (sokszogNev)
            {
                case "Háromszög":
                    oldalCLetezik = true;
                    break;
                default:
                    oldalCLetezik = false;
                    break;
            }
        }

        public void Calculate()
        {
            if (string.IsNullOrWhiteSpace(sokszogView.oldalA) 
                || string.IsNullOrWhiteSpace(sokszogView.oldalB))
            {
                return;
            }

            switch (sokszogNev)
            {
                case "Téglalap":
                    var teglalap = new Teglalap(
                        sokszogView.oldalA,
                        sokszogView.oldalB);
                    sokszogView.Kerulet = teglalap.Kerulet().ToString();
                    sokszogView.Terulet = teglalap.Terulet().ToString();
                    break;
                case "Háromszög":
                    if (string.IsNullOrWhiteSpace(haromszogView.oldalC))
                    {
                        return;
                    }
                    var haromszog = new Haromszog(
                        sokszogView.oldalA,
                        sokszogView.oldalB,
                        haromszogView.oldalC);
                    sokszogView.Kerulet = haromszog.Kerulet().ToString();
                    sokszogView.Terulet = haromszog.Terulet().ToString();
                    break;
                default:
                    sokszogView.Kerulet = null;
                    sokszogView.Terulet = null;
                    break;
            }
        }
    }
}
