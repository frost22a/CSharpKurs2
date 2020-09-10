using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Produkt // dodajemy identyfikator dostępu public
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
        public string NazwaProduktu { get; set; }

        /// <summary>
        /// sprawdzam dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()  // w "specyfikacji" mamy, że nazwisko oraz emial nie muszą być podane
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

    }
}
