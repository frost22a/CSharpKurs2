using System;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Zamowienie:KlasaBazowa
    {
        public Zamowienie()
        {

        }

        public Zamowienie(int zamowienieId)
        {
            this.ZamowienieId = zamowienieId;
        }

        public int ZamowienieId { get; private set; }
        public DateTimeOffset? DataZamowienia { get; set; }

        public List<PozycjaZamowienia> pozycjaZamowienia {get; set;}

        public int KlientID { get; set; }

        public int AdresDostawyID { get; set; } 


        /// <summary>
        /// sprawdzam dane produktu
        /// </summary>
        /// <returns></returns>
        public override bool Zwaliduj()  // w "specyfikacji" mamy, że nazwisko oraz emial nie muszą być podane
        {
            var poprawne = true;
            if (DataZamowienia == null)
                poprawne = false;
           
            return poprawne;
        }

        /// <summary>
        /// zapisuje zamowienie
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {
            return DataZamowienia.Value.Date + " (" + ZamowienieId + ")";
        }

    }

}
