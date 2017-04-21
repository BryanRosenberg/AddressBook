using System;
using System.Collections.Generic;

namespace AddressBook
{
    public class ContactManager
    {
        public ContactManager()
        {
            _contacts = new List<Contact>();
        }


        public void DoContactManager()
        {
            while (true)
            {
                ShowMenu();
                int choice = GetNumberFromUser();

                if (choice == 0)
                {
                    break;
                }
                else if (choice == 1)
                {
                    DoAddContactPerson();
                }
                else if (choice == 2)
                {
                    DoAddContactCompany();
                }
                else if (choice == 3)
                {
                    DoListAllContacts();
                }
                else if (choice == 4)
                {
                    DoSearchContacts();
                }
                else if (choice == 5)
                {
                    DoRemoveContact();
                }
                else if (choice == 6)
                {
                    DoRemoveAllContacts();
                }
            }
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("CONTACT MANAGER");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add a Person");
            Console.WriteLine("2. Add a Company");
            Console.WriteLine("3. List Contacts");
            Console.WriteLine("4. Search Contacts");
            Console.WriteLine("5. Remove Contact");
            Console.WriteLine("6. Remove All Contacts");
            Console.WriteLine();
            Console.WriteLine("0. Exit");
            Console.WriteLine("----------------------------------");
            Console.WriteLine("What would you like to do?");
        }

        private void DoAddContactPerson()
        {
            Console.Clear();
            Console.WriteLine("ADD A PERSON");
            Console.WriteLine("-------------------------------------");
            Console.Write("First Name? ");
            string inputFirstName = Console.ReadLine();
            Console.Write("Last Name? ");
            string inputLastName = Console.ReadLine();
            Console.Write("Phone Number? ");
            string inputPhoneNumber = Console.ReadLine();

            Person newPerson = new Person(inputFirstName, inputLastName, inputPhoneNumber);

            _contacts.Add(newPerson);
        }

        private void DoAddContactCompany()
        {
            Console.Clear();
            Console.WriteLine("ADD A COMPANY");
            Console.WriteLine("-------------------------------------");
            Console.Write("Company Name? ");
            string inputName = Console.ReadLine();
            Console.Write("Phone Number? ");
            string inputPhoneNumber = Console.ReadLine();

            Company newCompany = newCompany = new Company(inputName, inputPhoneNumber);

            _contacts.Add(newCompany);
        }

        private void printNumberedContactList()
        {
            for (int i = 0; i < _contacts.Count; i += 1)
            {
                Contact contact = _contacts[i];
                Console.WriteLine($"{i}. {contact}");
            }
        }

        private void DoListAllContacts()
        {
            Console.Clear();
            Console.WriteLine("CONTACT LIST");
            Console.WriteLine("-------------------------------------");

            printNumberedContactList();

            Console.WriteLine("-------------------------------------");
            Console.Write("Press Enter to return to the menu...");
            Console.ReadLine();
        }

        private void DoSearchContacts()
        {
            Console.Clear();
            Console.WriteLine("SEARCH CONTACT LIST");
            Console.WriteLine("-------------------------------------");
            Console.Write("Please enter a search term: ");
            string term = Console.ReadLine();

            foreach (Contact contact in _contacts)
            {
                if (contact.Matches(term))
                {
                    Console.WriteLine($"> {contact}");
                }
            }

            Console.Write("Press Enter to return to the menu...");
            Console.ReadLine();
        }

        private void DoRemoveContact()
        {
            Console.Clear();
            Console.WriteLine("REMOVE A CONTACT");
            Console.WriteLine("-------------------------------------");

            Console.Write("Please enter a search term: ");
            string term = Console.ReadLine();

            foreach (Contact contact in _contacts)
            {
                if (contact.Matches(term))
                {
                    Console.WriteLine($"> {contact}");
                    Console.WriteLine("Would you like to remove this contact (yes/no)?");
                    string input = Console.ReadLine();
                    if (input == "yes")
                    {
                        _contacts.Remove(contact);
                        return;
                    }
                }
            }

        }

        private void DoRemoveAllContacts()
        {
            _contacts.Clear();
        }

        //private void DoRemoveContact()
        //{
        //    Console.Clear();
        //    Console.WriteLine("REMOVE A CONTACT");
        //    Console.WriteLine("-------------------------------------");

        //    printNumberedContactList();

        //    Console.WriteLine();
        //    Console.Write("Please enter an index value: ");
        //    int index = GetNumberFromUser();
        //    _contacts.RemoveAt(index);
        //}

        private int GetNumberFromUser()
        {
            string input = Console.ReadLine();
            return int.Parse(input);
        }

        private List<Contact> _contacts;
    }
}
