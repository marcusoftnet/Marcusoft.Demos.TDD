using System;

namespace Marcusoft.Demos.TDD.ProdCode
{
    public class Person
    {
        public string F�rNamn { get; set; }
        public string FirstName { get; set; }
        public string EfterNamn { get; set; }
        public string LastName { get; set; }

        public string H�mtaKomplettNamn()
        {
            return F�rNamn + " " + EfterNamn;
        }

        public string FullName()
        {
            return FirstName + " " + LastName;
        }
    }
}