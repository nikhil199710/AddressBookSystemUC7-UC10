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
    /// <summary>
    /// Program class contains main function
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// Calls StartProgram function
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            MultipleAddressBook multipleAddressBook = new MultipleAddressBook();
            multipleAddressBook.multipleBook();
        }
    }
}
