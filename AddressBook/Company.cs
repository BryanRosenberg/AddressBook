using System;

namespace AddressBook
{
    public class Company : Contact
    {
        public Company(string name, string phoneNumber)
            : base(phoneNumber) 
        {
            _name = name;
        }

        // Gets the phoneNumber made availabe by Contact
        public override string ToString()
        {
            string phoneNumber = base.ToString();
            return $"{_name}, {phoneNumber}";
        }

        public override bool Matches(string term)
        {
            if (_name.StartsWith(term))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private string _name;
    }
}
