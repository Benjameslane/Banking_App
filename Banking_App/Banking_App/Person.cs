using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_App
{
    internal class Person
    {

        //private fields to store first and last name

        private string _firstName;
        private string _lastName;

        public Person(string firstName, string lastName)
        {
            _firstName = firstName;
            _lastName = lastName;
        }


        //method used to get full name of the person. The method is public so we are able to call upon the private strings of first and last name
        public string GetFullName()
        {
            return _firstName + " " + _lastName;
        }
    }
}
