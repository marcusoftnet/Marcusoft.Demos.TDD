using System;

namespace Marcusoft.Demos.TDD.ProdCode.EnkelDependencyInjection
{
    public class Affärslogik
    {
        private readonly IRepository _repository;

        /// <summary>
        /// Används av testkod
        /// Tar repository som ska användas som inparameter
        /// </summary>
        /// <param name="repository"></param>
        public Affärslogik(IRepository repository)
        {
            _repository = repository;
        }

        #region Fattigmans Inversion of Control
        /// <summary>
        /// Används av produktionskoden
        /// Skapar upp den "riktiga" implementationen av Repositoryt
        /// </summary>
        public Affärslogik()
        {
            _repository = new ProduktionsRepository();
        } 
        #endregion

        public string RapportBästaKunderna()
        {
            // Hämta alla kunder från databasen
            var allaKunder = _repository.HämtaAllaKunder();

            // Gör en snygg rapport
            var report = string.Empty;
            foreach (var kund in allaKunder)
            {
                report += "Detta är kund: " + kund.HämtaKomplettNamn() + Environment.NewLine;
            }
            return report;
        }
    }

	public class BusinessLogic
    {
        private readonly IRepository _repository;

        public BusinessLogic(IRepository repository)
        {
            _repository = repository;
        }

        #region Poor man Inversion of Control
        public BusinessLogic()
        {
            _repository = new ProduktionsRepository();
        } 
        #endregion

        public string Report5BestCustomers()
        {
            var allCustomers = _repository.GetAllCustomers();

            // Create fancy report
            var report = string.Empty;
            foreach (var c in allCustomers)
            {
                report += "Customer: " + c.FullName() + Environment.NewLine;
            }
            return report;
        }
    }

}