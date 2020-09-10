using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common;

namespace CommonTest
{
    [TestClass]
    public class ObslugaStringaTest
    {
        [TestMethod]
        public void WstawSpacjeTest()
        {
            //Arrange
            var zrodlo = "StółOgrodowy";
            var oczekiwana = "Stół Ogrodowy";
            var  obslugaStringa = new ObslugaStringa();

            //Act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //Arrange
            var zrodlo = "Ala    Ma Kota";
            var oczekiwana = "Ala Ma Kota";
            var  obslugaStringa = new ObslugaStringa();

            //Act
            var aktualna = obslugaStringa.WstawSpacje(zrodlo);

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
    }
}
