using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class Person
    {
        public int Age { get; set; }
        public string FirstName { get; set; } = "";
        public string LastName { get; set; } = "";

        public Person() { }
        public Person(int age, string firstName, string lastName)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString() => $"Name: {FirstName} {LastName}, Age: {Age}";
    }
}
