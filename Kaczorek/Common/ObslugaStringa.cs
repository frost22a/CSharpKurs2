using System;

namespace Common
{
    public static class ObslugaStringa
    {
        public static string WstawSpacje(this string zrodlo) // zmieniamy metodę static na metodę rozszerzenia - po pierwsze metoda rozszerzenia musi być w klasie statycznej
                                                        // po drugie - metoda musi być statyczna
                                                        // po trzecie dodajmy słowo kluczowe this - to powoduje, że motoda staje się rozszerzeniaem klasy pierwszego parametru metody, w tym wypadku string


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
