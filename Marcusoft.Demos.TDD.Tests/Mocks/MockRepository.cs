using System.Collections.Generic;
using Marcusoft.Demos.TDD.ProdCode;
using Marcusoft.Demos.TDD.ProdCode.EnkelDependencyInjection;

namespace Marcusoft.Demos.TDD.Tests.Mocks
{
    public class MockRepository : IRepository
    {
        public IEnumerable<Person> HämtaAllaKunder()
        {
            return GetAllCustomers();
        }

        public IEnumerable<Person> GetAllCustomers()
        {
            // make up some customers
            var all = new List<Person>();
            for (int i = 1; i <= 5; i++)
            {
                var p = new Person();
                p.FirstName = "Kalle #" + i.ToString();
                p.LastName = "Kula";

                all.Add(p);
            }
            return all;
        }
    }
}
