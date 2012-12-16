namespace Marcusoft.Demos.TDD.ProdCode
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string GetCompleteName()
        {
            return FirstName + " " + LastName;
        }
    }
}