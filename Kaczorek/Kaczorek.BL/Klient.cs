using Common;
using System.Collections.Generic;

namespace Kaczorek.BL
{
    public class Klient:KlasaBazowa, ILogowanie
    {
        #region konstruktory
        public Klient() : this(0) // poprzez :this(0) wywołujemy drugi konstruktor z tak zwaną listą inicjalizującą, np. trzeci konstruktor plus this(0, "stefan")
                                // jak tu zmienimy na private, to nie będzie można użyć tego konstruktora poza klasą
        {
    
        }

        public Klient(int KlinetId)
        {
            this.KlientId = KlinetId; // dodajemy ten konstruktor, bo KlinetId jest ustawione jako private i nie mamy do niej dostępu spoza klasy
            this.ListaAdresow = new List<Adres>();
        }
        //public Klient(int KlinetId, string imie)
        //{
        //    this.KlientId = KlinetId; // dodajemy ten konstruktor, bo KlinetId jest ustawione jako private i nie mamy do niej dostępu spoza klasy
        //    this.ListaAdresow = new List<Adres>();
        //    this.Imie = imie;
        //}



        #endregion

        #region właciwości
        //WŁAŚCIWOŚCI
        public static int licznik { get; set; }


        private string _nazwisko; //prywatne pole nazwisko - dostęp tylko z klasy, a spoza klasy przy pomocy akcesorów, za pomocą włąściwości:
        
        public string Nazwisko // właściwość pola _nazwisko || można wpisać modyfikator dostępu internal - wtedy właściwośc będzie dostępna tylko z wnętrza projektu
        {
            // get, set - akcesory plus logika do nicch:
            get // jak usuniemy get będziemy mogli tylko zapisywać poprzez set (włąściwość tylko do zapisu)| można rónież zrobić odwrotnie (właściwość tylko do odczytu)
            {
                // tutaj możemy dodać dowolny kod
                return _nazwisko;
            }
            set // ustawia wartość _nazwisko na value
            {
                // tutaj możemy dodać dowolny kod
                _nazwisko = value;
            }
        }
            // jest też możliwość ustawienia właściwości automatycznej - tutaj właściwość Imię:

            public string Imie { get; set; }
        // w obecnej sytuacji zapisy są równoważne - > brak dodatkowego kodu
        //skrót do utworzenia właściwości to prop + tab tab
        public string Email { get; set; }

        public int KlientId { get; private set; } // setter prywatny, nie będzie dostępu zewnątrz

        public string ImieNazwisko 
        {
            get 
            {
                string IN;
                if (!string.IsNullOrWhiteSpace(Imie))
                {
                    if (!string.IsNullOrWhiteSpace(Nazwisko)) IN = Imie + ", " + Nazwisko;
                    else IN = Imie;
                }
                else
                {
                    if (!string.IsNullOrWhiteSpace(Nazwisko)) IN = Nazwisko;
                    else IN = "";
                }

                return IN;
            } 
        }

        public List<Adres> ListaAdresow { get; set; }

        public int TypKlienta { get; set; }

        

        #endregion

        #region metody        
        //METODY

        public override bool Zwaliduj()  // w "specyfikacji" mamy, że nazwisko oraz emial nie muszą być podane
        {
            var poprawne = true;
            if (string.IsNullOrWhiteSpace(Nazwisko))
                poprawne = false;
            if (string.IsNullOrWhiteSpace(Email))
                poprawne = false;

            return poprawne;
        }

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
            // kod, który pobiera określonego klienta
            return new Klient();
        }

        /// <summary>
        /// pobieramy wszystkich klinetów
        /// </summary>
        /// <returns></returns>
        public List<Klient> Pobierz() 
        {
            // ko, który pobiera wszystkich klinetów
            return new List<Klient>();
        }

        public override string ToString()
        {
            return ImieNazwisko;
        }

        public string Log() 
        {
            var log = KlientId + ": " + ImieNazwisko + " " + "Email: " + Email + "Status: " + StanObiektu.ToString();
            return log;
        }

        #endregion 
    }
}

