using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaczorek.BL;

namespace Kaczorek.BL.Test
{
    [TestClass]
    public class KlientRepositoryTest
    {
        [TestMethod]
        public void PobierzKlientaTest()
        {
            //Arrange - przygotuj test
            var klientRepository = new KlinetRepository();
            var oczekiwana = new Klient(1){Email = "qw@qw.pl", Imie = "Marcin", Nazwisko = "Elo"};


            //ACT działaj
            var aktualna = klientRepository.Pobierz(1);

            //ASSERT
            // *** Assert.AreEqual(oczekiwana, aktualna); // ten test pokaże, że są to dwa różne OBIEKTY, mimo że mają te same wartości pól, dlatego musimy:
            Assert.AreEqual(oczekiwana.KlientId, aktualna.KlientId);
            Assert.AreEqual(oczekiwana.Email, aktualna.Email);
            Assert.AreEqual(oczekiwana.Nazwisko, aktualna.Nazwisko);
            Assert.AreEqual(oczekiwana.Imie, aktualna.Imie);

        }
    }
}
