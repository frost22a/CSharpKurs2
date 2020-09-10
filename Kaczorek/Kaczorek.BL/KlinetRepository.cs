using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class KlinetRepository
    {


        /// <summary>
        /// zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz()
        {
            // tu powinien być kod który zapisuje klineta
            return true;
        }

        /// <summary>
        /// pobieramy jednego klienta
        /// </summary>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //tworzymy instancje klasy klienta

            Klient klient = new Klient(klientId);

            // kod, który pobiera określonego klienta

            //tymczasowo wpisujemy wartości, aby zwrócić klineta

            if (klientId==1)
            {
                klient.Email = "qw@qw.pl";
                klient.Imie = "Marcin";
                klient.Nazwisko = "Elo";
            }

            return klient; // powinno być new Klient(), ale na potrzeby testów wpisujemy klinet 
        }

        /// <summary>
        /// pobieramy wszystkich klinetów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz()
        {
            // kod, który pobiera wszystkich klinetów
            return new List<Klient>();
        }
    }
}
