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
            // kod, który pobiera wszystkich klinetów
            return new List<Produkt>();
        }
        /// <summary>
        /// zapisuje produkt
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Produkt produkt)
        {
            // tu powinien być kod który zapisuje produkt
            var sukces = true;

            if (produkt.MaZmiany  && produkt.DanePrawidłowe)
            {
                if (produkt.JestNowy)
                {
                    //wywołać procedurę insert
                }
                else
                {
                    //wywołać procedurę update
                }
            }

            return sukces;
        }
    }
}
