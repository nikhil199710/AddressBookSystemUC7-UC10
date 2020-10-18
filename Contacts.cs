// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Contact.cs" company="Bridgelabz">
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
    /// Object of contact class stores all information of a contact
    /// </summary>
    public class Contacts
    {
        /// <summary>
        /// Variables to store first name, last name, address, city, state, zip, phone number and email 
        /// Easy to understand with given names
        /// </summary>
        public string firstName, lastName, address, city, email, state, phoneNumber;
        public int zip;
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact"/> class.
        /// </summary>
        public Contacts()
        {
            this.firstName = "";
            this.lastName = "";
            this.address = "";
            this.city = "";
            this.email = "";
            this.state = "";
            this.phoneNumber = "";
            this.zip = 0;
        }
    }
}