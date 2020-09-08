namespace Kaczorek.BL
{
    public class Klient
    {
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
    }
}

