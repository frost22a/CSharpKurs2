using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class WyswietleniePozycjiZamowienia
    {
        public int PozycjaZamowieniaId { get; set; }
        public int Ilosc { get; set; }
        public string NazwaProduktu { get; set; }
        public decimal? CenaZakupu { get; set; }

    }
}
