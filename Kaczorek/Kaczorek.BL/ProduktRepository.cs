using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class ProduktRepository
    {

        /// <summary>
        /// zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // tu powinien być kod który zapisuje produkt
            return true;
        }

        /// <summary>
        /// pobieramy jeden produkt
        /// </summary>
        /// <returns></returns>
        public Produkt Pobierz(int produktId)
        {
            // kod, który pobiera określonego klienta
            return new Produkt();
        }

        /// <summary>
        /// pobieramy wszystkie produkty
        /// </summary>
        /// <returns></returns>
        public List<Produkt> Pobierz()
        {
            // ko, który pobiera wszystkich klinetów
            return new List<Produkt>();
        }
    }
}
