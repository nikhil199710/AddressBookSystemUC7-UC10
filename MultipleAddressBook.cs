// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookPractice
{
    public class MultipleAddressBook
    /// <summary>
    /// multipleAddressMapper is a data structure used to store All AddressBooks created in the project
    /// which can be accessed with the help of their name
    /// </summary>
    {
        private Dictionary<string, AddressBook> multipleAddressMapper = new Dictionary<string, AddressBook>();

        /// <summary>
        /// multipleBook function asks user about which activity to be done
        /// </summary>
        public void multipleBook()
        {
            Console.WriteLine("Welcome to address book Program!");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nEnter 1 to add New Address Book \nEnter 2 to Add Contacts \nEnter 3 to Edit Contacts " +
                    "\nEnter 4 to Delete Contacts\nEnter 5 to search contact using city name" +
                    "\nEnter 6 to search contact using state name\nEnter any other key to exit");
                string options = Console.ReadLine();
                switch (options)
                {
                    case "1":
                        AddAddressBook();
                        break;
                    case "2":
                        AddContactsInAddressBook();
                        break;
                    case "3":
                        EditContactsOfAddressBook();
                        break;
                    case "4":
                        DeleteContactsOfAddressBook();
                        break;
                    case "5":
                        SearchContactWithCityName();
                        break;
                    case "6":
                        SearchContactWithStateName();
                        break;
                    default:
                        flag = false;
                        break;
                }
            }
        }
        /// <summary>
        /// AddAddressBook function is called when user want to create new AddressBook
        /// </summary>
        public void AddAddressBook()
        {
            Console.WriteLine("\nEnter Name for the New Address Book");
            string name = Console.ReadLine();
            if (multipleAddressMapper.ContainsKey(name))
            {
                Console.WriteLine("Address Book Already exist with this name");
            }
            else
            {
                AddressBook addressBook = new AddressBook();
                multipleAddressMapper.Add(name, addressBook);
            }
        }
        /// <summary>
        /// AddContactsInAddressBook is called when user ask to enter new contact details in any AddressBook
        /// </summary>

        public void AddContactsInAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to add new contact");
            string name = Console.ReadLine();
            if (!multipleAddressMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, AddressBook> tempPair in multipleAddressMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                AddressBook addressBook = multipleAddressMapper[name];
                addressBook.AddContacts();
            }
        }
        /// <summary>
        /// EditDetailsOfAddressBook is called when a user ask to modify Contact details in a AddressBook
        /// </summary>
        public void EditContactsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to modify contact details");
            string name = Console.ReadLine();
            if (!multipleAddressMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, AddressBook> tempPair in multipleAddressMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                AddressBook addressBook = multipleAddressMapper[name];
                addressBook.editContact();
            }
        }
        /// <summary>
        /// DeleteContactsOfAddressBook is called when user want to delete a particular contact from a AddressBook
        /// </summary>
        public void DeleteContactsOfAddressBook()
        {
            Console.WriteLine("\nEnter Name of address book to delete contact details");
            string name = Console.ReadLine();
            if (!multipleAddressMapper.ContainsKey(name))
            {
                Console.WriteLine("No address book found with this name");
                Console.WriteLine("Please Enter Valid Name from following names:");
                foreach (KeyValuePair<string, AddressBook> tempPair in multipleAddressMapper)
                {
                    Console.WriteLine(tempPair.Key);
                }
            }
            else
            {
                AddressBook addressBook = multipleAddressMapper[name];
                addressBook.deleteContact();
            }
        }
        private static void SearchContactWithCityName()
        {
            Console.WriteLine("\nEnter full name of the person!");
            string personName = Console.ReadLine();
            Console.WriteLine("\nEnter name of the city!");
            string cityName = Console.ReadLine();
            if (!cityToContactMapperGlobal.ContainsKey(cityName))
            {
                Console.WriteLine("No record found with such city name!");
                return;
            }
            foreach (Contact contact in cityToContactMapperGlobal[cityName])
            {
                if ((contact.firstName + " " + contact.lastName) == personName)
                {
                    Console.WriteLine("Contact found!");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                    return;
                }
            }
            Console.WriteLine($"No Contact Exist With This Name!");
        }

        private static void SearchContactWithStateName()
        {
            Console.WriteLine("\nEnter full name of the person!");
            string personName = Console.ReadLine();
            Console.WriteLine("\nEnter name of the state!");
            string stateName = Console.ReadLine();
            if (!stateToContactMapperGlobal.ContainsKey(stateName))
            {
                Console.WriteLine("No record found with this state name!");
                return;
            }
            foreach (Contact contact in stateToContactMapperGlobal[stateName])
            {
                if ((contact.firstName + " " + contact.lastName) == personName)
                {
                    Console.WriteLine("Contact found!");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                    return;
                }
            }
            Console.WriteLine($"No Contact Exist With This Name!");
        }
    }
}

