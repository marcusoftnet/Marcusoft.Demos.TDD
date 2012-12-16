using System.Collections.Generic;

namespace Marcusoft.Demos.TDD.ProdCode.EnkelDependencyInjection
{
    public interface IRepository
    {
        IEnumerable<Person> HämtaAllaKunder();
		IEnumerable<Person> GetAllCustomers();
    }
}