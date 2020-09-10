using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class PozycjaZamowienia
    {
        public PozycjaZamowienia()
        {
                
        }

        public PozycjaZamowienia(int pozycjaZamówieniaId)
        {
            this.PozycjaZamowieniaId = pozycjaZamówieniaId;
        }
        public int PozycjaZamowieniaId { get;private set; }
        public int Ilosc { get; set; }
        public int ProdutkId { get; set; }
        public decimal? CenaZakupu { get; set; }

        /// <summary>
        /// sprawdzam dane produktu
        /// </summary>
        /// <returns></returns>
        public bool Zwaliduj()  // w "specyfikacji" mamy, że nazwisko oraz emial nie muszą być podane
        {
            var poprawne = true;
            if (Ilosc <= 0)
                poprawne = false;
            if (ProdutkId <= 0)
                poprawne = false;
            if (CenaZakupu == 0)
                poprawne = false;

            return poprawne;
        }

        /// <summary>
        /// zapisuje pozycję zamówienia
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // tu powinien być kod który zapisuje pozycję zamówienie
            return true;
        }

        /// <summary>
        /// pobieramy jedeą pozycję zamówienia
        /// </summary>
        /// <returns></returns>
        public PozycjaZamowienia Pobierz(int pozycjaZamowieniaId)
        {
            // kod, który pobiera określonego klienta
            return new PozycjaZamowienia();
        }

        /// <summary>
        /// pobieramy wszystkie pozycja z zamowienia
        /// </summary>
        /// <returns></returns>
        public List<PozycjaZamowienia> Pobierz()
        {
            // kod, który pobiera wszystkie pozycje z zamówienia
            return new List<PozycjaZamowienia>();
        }

    }
}
