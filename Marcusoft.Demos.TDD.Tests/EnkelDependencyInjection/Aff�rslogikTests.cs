using System.Collections.Generic;
using Marcusoft.Demos.TDD.ProdCode;
using Marcusoft.Demos.TDD.ProdCode.EnkelDependencyInjection;
using Marcusoft.Demos.TDD.Tests.Mocks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NSubstitute;

namespace Marcusoft.Demos.TDD.Tests.EnkelDependencyInjection
{
    [TestClass]
    public class AffärslogikTests
    {
        [TestMethod]
        public void ska_returnera_korrekt_rapport_för_5_kunder_i_databasen()
        {
            // Arrange
            var rep = new MockRepository();
            var affärslogik = new Affärslogik(rep);

            // Act
            var resultat = affärslogik.RapportBästaKunderna();

            // Assert
            var förväntadRapport = "Detta är kund: Kalle #1 Kula" + Environment.NewLine +
                                   "Detta är kund: Kalle #2 Kula" + Environment.NewLine +
                                   "Detta är kund: Kalle #3 Kula" + Environment.NewLine +
                                   "Detta är kund: Kalle #4 Kula" + Environment.NewLine +
                                   "Detta är kund: Kalle #5 Kula" + Environment.NewLine;

            Assert.AreEqual(förväntadRapport, resultat);
        }

		[TestMethod]
        public void returns_proper_formatted_report_for_5_best_customers()
        {
            // Arrange
            var rep = new MockRepository();

			// Supply dependency
            var biz = new BusinessLogic(rep);

            // Act
            var result = biz.Report5BestCustomers();

            // Assert
            var expectedReport = "Customer: Kalle #1 Kula" + Environment.NewLine +
                                 "Customer: Kalle #2 Kula" + Environment.NewLine +
                                 "Customer: Kalle #3 Kula" + Environment.NewLine +
                                 "Customer: Kalle #4 Kula" + Environment.NewLine +
                                 "Customer: Kalle #5 Kula" + Environment.NewLine;

            Assert.AreEqual(expectedReport, result);
        }

        [TestMethod]
        public void with_mock_framewokr()
        {
            // Arrange
            var rep = Substitute.For<IRepository>();

            // Configure the mock
            rep.GetAllCustomers().Returns(
                new List<Person>
                    {
                        new Person {FirstName = "Kalle", LastName = "#1 Kula"},
                        new Person {FirstName = "Kalle", LastName = "#2 Kula"},
                        new Person {FirstName = "Kalle", LastName = "#3 Kula"},
                        new Person {FirstName = "Kalle", LastName = "#4 Kula"},
                        new Person {FirstName = "Kalle", LastName = "#5 Kula"}
                    });

            // Supply dependency
            var biz = new BusinessLogic(rep);

            // Act
            var result = biz.Report5BestCustomers();

            // Assert
            var expectedReport = "Customer: Kalle #1 Kula" + Environment.NewLine +
                                 "Customer: Kalle #2 Kula" + Environment.NewLine +
                                 "Customer: Kalle #3 Kula" + Environment.NewLine +
                                 "Customer: Kalle #4 Kula" + Environment.NewLine +
                                 "Customer: Kalle #5 Kula" + Environment.NewLine;

            Assert.AreEqual(expectedReport, result);
        }
			
    }
}
