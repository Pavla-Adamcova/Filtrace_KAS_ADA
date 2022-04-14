using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtrace_KAS_ADA
{

    class Drogerka
    {
        //Vlastnosti
        public int Druh { get; private set; }
        public int Znacka { get; private set; }
        public int Cena {get; private set; }
        public bool Dostupnost { get; private set; }
        public string Typ { get; private set; }
        public DateTime Trvanlivsot { get; private set; }
        public int Obsah { get; private set; }

        //Konstruktor
        public Drogerka(int druh, int znacka, int cena, bool dostupnost, string typ, DateTime trvanlivost, int obsah)
        {
            //Naplnění
            Druh = druh;
            Znacka = znacka;
            Cena = cena;
            Dostupnost = dostupnost;
            Typ = typ;
            Trvanlivsot = trvanlivost;
            Obsah = obsah;
        }
        
    }
}
