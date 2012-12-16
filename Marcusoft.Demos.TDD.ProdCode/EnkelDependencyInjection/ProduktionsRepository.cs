using System;
using System.Collections.Generic;

namespace Marcusoft.Demos.TDD.ProdCode.EnkelDependencyInjection
{
    public class ProduktionsRepository : IRepository
    {
        public IEnumerable<Person> HämtaAllaKunder()
        {
            // returnera personer från databasen
            // ...
            return new List<Person>();
        }

        public IEnumerable<Person> GetAllCustomers()
        {
            // return from database
            // ...
            return new List<Person>();
        }
    }
}