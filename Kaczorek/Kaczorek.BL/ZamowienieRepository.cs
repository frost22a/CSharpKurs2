using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class ZamowienieRepository
    {

        public bool Zapisz(Zamowienie zamowienie)
        {
            // tu powinien być kod który zapisuje produkt
            var sukces = true;

            if (zamowienie.MaZmiany && zamowienie.DanePrawidłowe)
            {
                if (zamowienie.JestNowy)
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
        /// pobieramy jedno zamowienie
        /// </summary>
        /// <returns></returns>

        public WyswietlanieZamowienia PobierzZamowienieDoWyswietlenia(int zamowienieId) 
        {
            WyswietlanieZamowienia wyswietlanieZamowienia = new WyswietlanieZamowienia();

            //kod, który pobiera zdefiniowane pola zamówienia

            //tymczasowe dane
            if (zamowienieId == 10)
            {
                wyswietlanieZamowienia.Imie = "Tomek";
                wyswietlanieZamowienia.Nazwisko = "Nowak";
                wyswietlanieZamowienia.DataZamowienia = new DateTimeOffset(2020, 10, 09, 12, 45, 50, new TimeSpan(5,0,0));
                wyswietlanieZamowienia.AdresDostawy = new Adres() { AdresTyp = 2, ULica = "chojnicka", Miasto = "złotów", Kraj = "Poland", KodPocztowy="77-400" };
                wyswietlanieZamowienia.wyswietleniePozycjiZamowieniaLista = new List<WyswietleniePozycjiZamowienia>();

                //kod, który pobiera elementy zamówienia

                //tymczasowe dane zakodowane na stałe:

                if (zamowienieId == 10)
                {
                    var wyswietlaniePozycjiZamowienia = new WyswietleniePozycjiZamowienia()
                    {
                        NazwaProduktu = "stół",
                        CenaZakupu = 300.50M,
                        Ilosc = 10,

                    };
                    wyswietlanieZamowienia.wyswietleniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);


                    wyswietlaniePozycjiZamowienia = new WyswietleniePozycjiZamowienia()
                    {
                        NazwaProduktu = "krzesło",
                        CenaZakupu = (decimal)33.5,
                        Ilosc = 12,

                    };
                    wyswietlanieZamowienia.wyswietleniePozycjiZamowieniaLista.Add(wyswietlaniePozycjiZamowienia);

                }
               
            }
            return wyswietlanieZamowienia;
        }
        
    }
}
