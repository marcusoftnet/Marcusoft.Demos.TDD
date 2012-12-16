using System;
using Marcusoft.Demos.TDD.ProdCode;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Marcusoft.Demos.TDD.Tests
{
    [TestClass]
    public class PersonTests
    {
        #region Färdig TestKod
        [TestMethod]
        public void ska_hämta_komplett_namn_för_person_med_för_efternamn_satt()
        {
            // Arrange
            var p = new Person();
            p.FörNamn = "Kalle";
            p.EfterNamn = "Kula";

            // Act
            var helaNamnet = p.HämtaKomplettNamn();

            // Assert
            Assert.AreEqual("Kalle Kula", helaNamnet);
        }

        #endregion

        [TestMethod]
        public void ska_returnera_Anna_Anka_för_hämtaKomplettNamn_då_namn_Anka_Anka()
        {
            // Arrange
            var p = new Customer();
            p.FirstName = "Anna";
            p.LastName = "Anka";

            // Act
            var name = p.GetCompleteName();

            // Assert
            Assert.AreEqual("Anna Anka", name);
        }

        [TestMethod]
        public void should_return_Christer_Brännström_for_CompleteName()
        {
            // Arrange
            var p = new Customer();
            p.FirstName = "Christer";
            p.LastName = "Brännström";

            // Act
            var name = p.GetCompleteName();

            // Assert
            Assert.AreEqual("Christer Brännström", name);
        }
    }
}
