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

            //Act
            var aktualna = zrodlo.WstawSpacje(); // równoważne var aktualna = ObslugaStringa.WstawSpacje(zrodlo);

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
        [TestMethod]
        public void WstawSpacjeTestZeSpacja()
        {
            //Arrange
            var zrodlo = "Ala    Ma Kota";
            var oczekiwana = "Ala Ma Kota";
            
            //Act
            var aktualna = ObslugaStringa.WstawSpacje(zrodlo);

            //Assert
            Assert.AreEqual(oczekiwana, aktualna);

        }
    }
}
