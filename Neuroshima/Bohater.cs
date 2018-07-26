using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuroshima {
    static class Bohater {
        static string Nazwa { get; set; }
        static string Pochodzenie { get; set; }
        static string PochodzenieCecha { get; set; }
        static string Profesja { get; set; }
        static string ProfesjaCecha { get; set; }
        static string Choroba { get; set; }

        public static void WypelnijInfoBohatera(string imie,string pochodzenie,string pochodzeniececha,string profesja,
                                                 string profesjacecha,string choroba) {
            Bohater.Nazwa = imie;
            Bohater.Pochodzenie = pochodzenie;
            Bohater.PochodzenieCecha = pochodzeniececha;
            Bohater.Profesja = profesja;
            Bohater.ProfesjaCecha = profesjacecha;
            Bohater.Choroba = choroba;
        }
    }
}
