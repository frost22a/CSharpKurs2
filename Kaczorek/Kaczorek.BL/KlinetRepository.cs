﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class KlinetRepository
    {
        private AdresRepository adresRepository { get; set; }

        public KlinetRepository()
        {
            adresRepository = new AdresRepository();
        }

        /// <summary>
        /// zapisuje klienta
        /// </summary>
        /// <returns></returns>
        public bool Zapisz(Klient klient)
        {
            // tu powinien być kod który zapisuje produkt
            var sukces = true;

            if (klient.MaZmiany && klient.DanePrawidłowe)
            {
                if (klient.JestNowy)
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

        /// <summary>
        /// pobieramy jednego klienta
        /// </summary>
        /// <returns></returns>
        public Klient Pobierz(int klientId)
        {
            //tworzymy instancje klasy klienta

            Klient klient = new Klient(klientId);
            klient.ListaAdresow = adresRepository.PobierzPoKlinetID(klientId).ToList();
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
