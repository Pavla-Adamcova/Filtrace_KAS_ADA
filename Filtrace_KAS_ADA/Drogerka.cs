using System;

namespace Filtrace_KAS_ADA
{

    class Drogerka
    {
        //Vlastnosti
        public int ID { get; private set; }
        public int Druh { get; private set; }
        public int Znacka { get; private set; }
        public int Cena { get; private set; }
        public bool Dostupnost { get; private set; }
        public string Typ { get; private set; }
        public DateTime Trvanlivsot { get; private set; }
        public int Obsah { get; private set; }

        //Konstruktor
        public Drogerka(int id, int druh, int znacka, int cena, bool dostupnost, string typ, DateTime trvanlivost, int obsah)
        {
            //Naplnění
            ID = id;
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
