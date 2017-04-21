using System;

namespace AddressBook
{
    public abstract class Contact // abstract = idea
    {
        public Contact(string phoneNumber)
        {
            _phoneNumber = phoneNumber;
        }

        // makes the _phoneNumber available to Person and Company classes
        public override string ToString()
        {
            return _phoneNumber;
        }

        // placeholder so that all of the code knows that the contact has a Matches method
        // virtual = modify a method; allow for it to be overridden in a derived class

        //public abstract bool Matches(string term);

        public virtual bool Matches(string term)
        {
            return false;
        }

        private string _phoneNumber;
    }

}
