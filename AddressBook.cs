// --------------------------------------------------------------------------------------------------------------------
// <copyright file="AddressBook.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Nikhil Kumar Yadav"/>
// --------------------------------------------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookPractice
{
    /// <summary>
    /// New object of AddressBook is instantiated to create new class
    /// </summary>
    class AddressBook
    {
        /// <summary>
        /// contactList stores all contacts of one AddressBook
        /// </summary>
        public List<Contacts> contactList = new List<Contacts>();
        /// <summary>
        /// nameToContactMapper is used to access contact details using name of person
        /// </summary>
        public Dictionary<string, Contacts> contactFromDatabase = new Dictionary<string, Contacts>();

        /// <summary>
        /// This function is used to add new Contact in AddressBook
        /// </summary>
        public void AddContacts()
        {
            bool flag = true;
            string first_name, last_name, _address, _city, _state, phone_number, _email;
            int _zip;
            while (flag)
            {
                Console.WriteLine("Enter First Name of Contact");
                first_name = Console.ReadLine();
                if (this.contactFromDatabase.ContainsKey(first_name))
                {
                    Console.WriteLine("A contact already exist with this name, try again!\n");
                    AddContacts();
                    return;
                }
                Console.WriteLine("Enter Last Name");
                last_name = Console.ReadLine();
                Console.WriteLine("Enter Address");
                _address = Console.ReadLine();
                Console.WriteLine("Enter City");
                _city = Console.ReadLine();
                Console.WriteLine("Enter state");
                _state = Console.ReadLine();
                Console.WriteLine("Enter zip");
                _zip = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Phone Number");
                phone_number = Console.ReadLine();
                Console.WriteLine("Enter Email");
                _email = Console.ReadLine();

                Contacts contact = new Contacts();
                contact.firstName = first_name;
                contact.lastName = last_name;
                contact.address = _address;
                contact.city = _city;
                contact.state = _state;
                contact.zip = _zip;
                contact.phoneNumber = phone_number;
                contact.email = _email; contactList.Add(contact);
                contactFromDatabase.Add(contact.firstName, contact);
                Console.WriteLine("Contact created successfully with following details: ");
                Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                Console.WriteLine("\nTo Add a New Contact Enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                {
                    flag = false;
                }
            }
        }

        /// <summary>
        /// EditDetails is used to modify contact details of a person using complete name
        /// </summary>
        public void editContact()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\nTo modify details, enter the firstname");
                string name = Console.ReadLine();
                if (contactFromDatabase.ContainsKey(name))
                {
                    Contacts contact = contactFromDatabase[name];
                    Console.WriteLine("Enter Latest Details of Contact!");

                    Console.WriteLine("Enter First Name of Contact");
                    string firstName = Console.ReadLine();
                    contact.firstName = firstName;

                    Console.WriteLine("Enter Last Name of Contact");
                    string lastName = Console.ReadLine();
                    contact.lastName = lastName;

                    Console.WriteLine("Enter Address");
                    string address = Console.ReadLine();
                    contact.address = address;

                    Console.WriteLine("Enter City");
                    string city = Console.ReadLine();
                    contact.city = city;

                    Console.WriteLine("Enter state");
                    string state = Console.ReadLine();
                    contact.state = state;

                    Console.WriteLine("Enter zip");
                    int zip = Convert.ToInt32(Console.ReadLine());
                    contact.zip = zip;

                    Console.WriteLine("Enter Phone Number");
                    string phoneNumber = Console.ReadLine();
                    contact.phoneNumber = phoneNumber;

                    Console.WriteLine("Enter Email");
                    string email = Console.ReadLine();
                    contact.email = email;

                    Console.WriteLine("\nDetails modified successfully with following entries: ");
                    Console.WriteLine("FirstName: " + contact.firstName + "\nLast Name :" + contact.lastName);
                    Console.WriteLine("Address: " + contact.address + "\nCity: " + contact.city);
                    Console.WriteLine("State: " + contact.state + "\nZip: " + contact.zip);
                    Console.WriteLine("Phone Number: " + contact.phoneNumber + "\nEmail: " + contact.email);
                }
                else
                {
                    Console.WriteLine("Entered name did't match with any record!");
                }
                Console.WriteLine("\nTo update more contact details enter YES");
                string option = Console.ReadLine();
                if (option != "YES")
                    flag = false;
            }


        }
        /// <summary>
        /// DeleteContact function is used to delete Contact from AddressBook using full name of the person
        /// </summary>
        public void deleteContact()
        {
            Console.WriteLine("\nTo delete details, enter the firstname");
            string name = Console.ReadLine();
            if (contactFromDatabase.ContainsKey(name))
            {
                contactFromDatabase.Remove(name);
            }
        }

    }
}



