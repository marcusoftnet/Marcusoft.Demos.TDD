using System;

namespace Marcusoft.Demos.TDD.ProdCode
{
    public class Person
    {
        public string FörNamn { get; set; }
        public string FirstName { get; set; }
        public string EfterNamn { get; set; }
        public string LastName { get; set; }

        public string HämtaKomplettNamn()
        {
            return FörNamn + " " + EfterNamn;
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}