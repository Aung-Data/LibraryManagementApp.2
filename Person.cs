using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryManagementApp._2
{
    public class Person
    {
        //Person class properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Person class constructor
        public Person(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }

        //Virtual method for polymorphism
        public virtual void DisplayDetails()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
