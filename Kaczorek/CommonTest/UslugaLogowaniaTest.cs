using System;
using System.Collections.Generic;
using Common;
using Kaczorek.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace CommonTest
{
    [TestClass]
    public class UslugaLogowaniaTest
    {
        [TestMethod]
        public void PiszDoPlikuTest()
        {
            //Arrange
            var zmienioneElementy = new List<ILogowanie>();
            var klient = new Klient(1)
            {
                Email = "qpa@qpa.pl",
                Imie = "Tadzio",
                Nazwisko = "Grzyb",
                ListaAdresow = null
            };

            zmienioneElementy.Add(klient);

            var produkt = new Produkt(5)
            {
                NazwaProduktu = "Mycha",
                Opis = "Pycha",
                AktualnaCena= 100000000M
            };
            zmienioneElementy.Add(produkt as ILogowanie);
            //Act

            UslugaLogowania.PiszDoPliku(zmienioneElementy);

            //Assert

        }
    }
}
