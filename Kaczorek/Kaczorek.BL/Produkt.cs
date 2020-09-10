using System;
using System.Collections.Generic;
using Common;


namespace Kaczorek.BL
{
    public class Produkt:KlasaBazowa , ILogowanie // dodajemy identyfikator dostępu public 
    {
        public Produkt() // dodajmy (musimy go dodać) ten konstruktor, ponieważ chcemy dodać przeciążony konstruktor z identyfikatorem ID
        {

        }

        public Produkt(int produktId)
        {
            ProduktId = produktId;
        }

        public int ProduktId { get; private set; } //propg tab tab
        public Decimal? AktualnaCena { get; set; } //Decimal? - oznacza że mamy deciaml ale może też być null
        public string Opis { get; set; }
        private string _NazwaProduktu;

        public string NazwaProduktu
        {
            get 
            {
                //return ObslugaStringa.WstawSpacje(_NazwaProduktu); 
                // wersja z metodą rozszerzoną (działa w tym wypadku jak String):
                return _NazwaProduktu.WstawSpacje();
            }
            set { _NazwaProduktu = value; }
        }


        /// <summary>
        /// sprawdzam dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()  // w "specyfikacji" mamy, że nazwisko oraz emial nie muszą być podane
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(NazwaProduktu))
                poprawne = false;
            if (AktualnaCena == null)
                poprawne = false;

            return poprawne;
        }

        //przesłąniamy metodę z klasy bazowej

        public override string ToString()
        {
            return NazwaProduktu;
        }

        public string Log()
        {
            var log = ProduktId + ": " + NazwaProduktu + " " + "Opis: " + Opis + "Status: " + StanObiektu.ToString();
            return log;
        }


    }
}
