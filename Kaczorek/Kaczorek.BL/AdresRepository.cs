using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class AdresRepository
    {
        /// <summary>
        /// pobieramy jeden adres
        /// </summary>
        /// <returns></returns>
        public Adres Pobierz(int adresId)
        {
            //Towrzymy instancję klasy Adres i przekazujemy żadany identyfikator
            Adres adres = new Adres(adresId);
            return adres;
        }
        public IEnumerable<Adres> PobierzPoKlinetID(int adresId)
        {
            //Towrzymy tymczasowo listę adresów na potrzeby aplikacji
            var listaAdresow = new List<Adres>(); // towrzymy listę adresów
            Adres adres = new Adres(1) { AdresTyp = 3, KodPocztowy = "77-400", Miasto = "Złotów", ULica = "gnojna" }; // tworzymy pierwszy adres
            listaAdresow.Add(adres); // dodajemy do listy

            // tworzymy drugi adres, używamy tej samej zmiennej, zmienna istnieje - nie używamy var
            adres = new Adres(2) { AdresTyp = 1, KodPocztowy = "77-420", Miasto = "Lipka", ULica = "gnojna" };
            listaAdresow.Add(adres);

            return listaAdresow;
        }
        
        /// <summary>
        /// zapisuje aktulany adres
        /// </summary>
        /// <param name="adres"></param>
        /// <returns></returns>
        public bool Zapisz(Adres adres)
        {
            // tu powinien być kod który zapisuje klineta
            return true;
        }
    }
}
