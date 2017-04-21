using System;

namespace AddressBook
{
    public class Person : Contact
    {
        // constructor - lastName and phoneNumber are required
        // "this" points to the other constructor method
        public Person(string lastName, string phoneNumber)
            : this(null, lastName, phoneNumber)
        {
        }

        // constructor - "method overloading" - added first name to the requirements
        public Person(string firstName, string lastName, string phoneNumber)
            : base(phoneNumber)
        {
            _firstName = firstName;
            _lastName = lastName;
        }

        // Gets the phoneNumber made availabe by Contact
        public override string ToString()
        {
            string phoneNumber = base.ToString();
            return $"{_lastName}, {_firstName}, {phoneNumber}";
        }

        public override bool Matches(string term)
        {
            if (_firstName.StartsWith(term) || _lastName.StartsWith(term))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string _firstName;
        private string _lastName;
    }
}
