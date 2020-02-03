using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person aPerson=new Person();
            aPerson.FirstName = "Ishmam";
            aPerson.MiddleName = "abir";
            aPerson.LastName = "chowdhury";

            Console.WriteLine(aPerson.GetFullName());

            Person nwPerson=new Person("hasan","abdullah","mehraj");
            Console.WriteLine(nwPerson.GetFullName());

            Console.ReadKey();
        }
    }
}
