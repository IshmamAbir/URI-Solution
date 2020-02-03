using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    class Person
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            Console.WriteLine("Default Constructor parameterless");

        }

        public Person(string firstName,string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public Person(string firstName,string middleName,string lastName) :this(firstName,lastName)
        {
            
            this.MiddleName = middleName;
            

            Console.WriteLine("parameterize Constructor");
        }

        public string GetFullName()
        {
            return FirstName + " " + MiddleName + " " + LastName;

        }
    }
}
