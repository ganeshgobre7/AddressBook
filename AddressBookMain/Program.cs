﻿using System;

namespace AddressBookMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to the Address Book Program");
            Addressbook addressbook = new Addressbook();
            addressbook.acceptData();
            addressbook.displayData();
             
        }
    }
}
