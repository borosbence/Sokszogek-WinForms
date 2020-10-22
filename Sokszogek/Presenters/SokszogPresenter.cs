using Sokszogek.Models;
using Sokszogek.Repositories;
using Sokszogek.ViewInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokszogek.Presenters
{
    class SokszogPresenter
    {
        private ISokszogekView view;
        private SokszogRepo repo;
        public bool oldalBLetezik;
        public bool oldalCLetezik;
        private string kijeloltSokszog;

        public SokszogPresenter(ISokszogekView param)
        {
            view = param;
            repo = new SokszogRepo();
        }

        public void LoadData()
        {
            view.SokszogList = repo.GetSokszogek();
        }

        public void GetSokszogType(int index)
        {
            kijeloltSokszog = repo.GetNameByIndex(index);
            switch (kijeloltSokszog)
            {
                case "Téglalap":
                    oldalBLetezik = true;
                    oldalCLetezik = false;
                    break;
                case "Háromszög":
                    oldalBLetezik = true;
                    oldalCLetezik = true;
                    break;
                default:
                    oldalBLetezik = false;
                    oldalCLetezik = false;
                    break;
            }
        }

        public void Calculate()
        {
            view.errorOldalA = null;
            view.errorOldalB = null;
            view.errorOldalC = null;
            switch (kijeloltSokszog)
            {
                case "Négyzet":
                    double A = 0;
                    double.TryParse(view.oldalA, out A);
                    if (A > 0)
                    {
                        var negyzet = new Negyzet(Convert.ToDouble(view.oldalA));
                        view.Kerulet = negyzet.Kerulet().ToString();
                        view.Terulet = negyzet.Terulet().ToString();
                    }
                    else
                    {
                        view.errorOldalA = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    break;
                case "Téglalap":
                    double B = 0;
                    double.TryParse(view.oldalA, out A);
                    double.TryParse(view.oldalB, out B);
                    if (A > 0 && B > 0)
                    {
                        var teglalap = new Teglalap(
                                Convert.ToDouble(view.oldalA),
                                Convert.ToDouble(view.oldalB));
                        view.Kerulet = teglalap.Kerulet().ToString();
                        view.Terulet = teglalap.Terulet().ToString();
                    }
                    else if (A <= 0 && B <= 0)
                    {
                        view.errorOldalA = "Kérem adjon meg 0-nál nagyobb számot!";
                        view.errorOldalB = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    else if (A <= 0)
                    {
                        view.errorOldalA = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    else if (B <= 0)
                    {
                        view.errorOldalB = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    break;
                case "Háromszög":
                    double C = 0;
                    double.TryParse(view.oldalA, out A);
                    double.TryParse(view.oldalB, out B);
                    double.TryParse(view.oldalC, out C);
                    if (A > 0 && B > 0 && C > 0)
                    {
                        var haromszog = new Haromszog(
                                Convert.ToDouble(view.oldalA),
                                Convert.ToDouble(view.oldalB),
                                Convert.ToDouble(view.oldalC));
                        view.Kerulet = haromszog.Kerulet().ToString();
                        view.Terulet = haromszog.Terulet().ToString();
                    }
                    else if (A <= 0)
                    {
                        view.errorOldalA = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    else if (B <= 0)
                    {
                        view.errorOldalB = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    else if (C <= 0)
                    {
                        view.errorOldalC = "Kérem adjon meg 0-nál nagyobb számot!";
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
