using System;

namespace Common
{
    public class ObslugaStringa
    {
        public string WstawSpacje(string zrodlo)
        {
            string wynik = string.Empty;
            if (!String.IsNullOrWhiteSpace(zrodlo))
            {
                foreach (char litera in zrodlo)
                {
                    if (char.IsUpper(litera))
                    {
                        //najpierw przycinamy wszystkie spacje, które są na początku i NA KOŃCU - > tak działą Trim(), a następnie wpisujemy "naszą"
                        wynik = wynik.Trim();
                        wynik+=" ";
                    }
                    wynik += litera;
                }
                wynik = wynik.Trim(); // wycinamy spacje przed i po łańcuchu znaków
            }
            return wynik;
        }

    }
}
