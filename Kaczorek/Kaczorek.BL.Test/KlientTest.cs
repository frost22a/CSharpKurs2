using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kaczorek.BL;

namespace Kaczorek.BL.Test
{
    [TestClass]
    public class KlientTest
    {
        [TestMethod]
        public void ImieNazwiskoTest()
        {
            // Arrange - przygotuj test

            Klient klient = new Klient();
            klient.Imie = "Robert";
            klient.Nazwisko = "Kowalski";
            string oczekiwana = "Robert, Kowalski";

            //Act - działaj
            string aktulana = klient.ImieNazwisko;

            //Assert - potwierdź test
            Assert.AreEqual(oczekiwana, aktulana);

        }

        [TestMethod]
        public void ImiePusteTest()
        {
            // Arrange - przygotuj test

            Klient klient = new Klient();
            //klient.Imie = "Robert";
            klient.Nazwisko = "Kowalski";
            string oczekiwana = "Kowalski";

            //Act - działaj
            string aktulana = klient.ImieNazwisko;

            //Assert - potwierdź test
            Assert.AreEqual(oczekiwana, aktulana);

        }

        [TestMethod]
        public void NazwiskoPusteTest()
        {
            // Arrange - przygotuj test

            Klient klient = new Klient();
            klient.Imie = "Robert";
            //klient.Nazwisko = "Kowalski";
            string oczekiwana = "Robert";

            //Act - działaj
            string aktulana = klient.ImieNazwisko;

            //Assert - potwierdź test
            Assert.AreEqual(oczekiwana, aktulana);

        }
    }
}
