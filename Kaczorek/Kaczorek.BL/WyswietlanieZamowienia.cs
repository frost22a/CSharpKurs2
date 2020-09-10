﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaczorek.BL
{
    public class WyswietlanieZamowienia
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public DateTimeOffset DataZamowienia { get; set; }
        public List<WyswietleniePozycjiZamowienia> wyswietleniePozycjiZamowieniaLista{ get; set; }
        public int ZamowienieId { get; set; }
        public Adres AdresDostawy { get; set; }
    }
}
