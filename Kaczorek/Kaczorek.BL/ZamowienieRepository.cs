using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {

        public bool Zapisz()
        {
            // tu powinien być kod który zapisuje klineta
            return true;
        }

        /// <summary>
        /// pobieramy jeden produkt
        /// </summary>
        /// <param name="zamowienieId"></param>
        /// <returns></returns>
        public Zamowienie Pobierz(int zamowienieId)
        {
            // kod, który pobiera określonego klienta
            return new Zamowienie();
        }

        /// <summary>
        /// pobieramy wszystkie zamowienia
        /// </summary>
        /// <returns></returns>
        public List<Zamowienie> Pobierz()
        {
            // ko, który pobiera wszystkich klinetów
            return new List<Zamowienie>();
        }
    }
}
