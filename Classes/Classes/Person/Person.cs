using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Classes.Classes.Person
{

    //Define  a class
    public partial  class Person
    {//constructor defining
        public Person()
        {

        }
       
        public Person(string firstName, string lastName, string taxNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            _taxNumber = taxNumber;
        }

        //Properties /Data Members
        public  required string FirstName { get; set; }
        public required string LastName { get; set; }
        public DateOnly DateOfBirth { get; set; }
        //Field Member
        private string _taxNumber;
        protected string _idNumber = "N/A ";
        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} , {LastName}");
        }
        public void PrintInitials()
        {
            var fisrtInitial = FirstName[0];
            var secondInitial = LastName[0];
            Console.WriteLine($"{FirstName[0]} , {LastName[0]}");
        }
        public void GenerateTaxNumber()
        {
            if (string.IsNullOrEmpty(_taxNumber))
            {
                _taxNumber = GetRandomNumber();
            }
            else
            {
                Console.WriteLine(" Tax number already exist");
            }
        }
        public string GetTaxNumber()
        {
            return _taxNumber;
        }
        public string GetIDNumber()
        {
            return _idNumber;
        }
        
        protected string GetRandomNumber()
        {
            return RandomNumberGenerator
                 .GetInt32(100000,
                 9999999).
                 ToString();
        }
    }
   
}
