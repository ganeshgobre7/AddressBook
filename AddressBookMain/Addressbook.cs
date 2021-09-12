using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{
    class Addressbook
    {
        String firstName;
        String lastName;
        String address;
        string city;
        string state;
        int zip;
        long phoneNo;
        string email;

        List<User> listUser = new List<User>();
        public void acceptData()
        {
            Console.Write("Enter your First Name :");
            string firstName = Console.ReadLine();
            Console.Write("Enter your Last Name :");
            string lastName = Console.ReadLine();
            Console.Write("Enter your Address :");
            string address = Console.ReadLine();
            Console.Write("Enter your City :");
            string city = Console.ReadLine();
            Console.Write("Enter your State :");
            string state = Console.ReadLine();
            Console.Write("Enter your Zip code :");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter your Phone number :");
            long phoneNo = long.Parse(Console.ReadLine());
            Console.Write("Enter your Email :");
            string email = Console.ReadLine();

            listUser.Add(new User()
            {
                firstName = firstName,
                lastName = lastName,
                address = address,
                city = city,
                state = state,
                zip = zip,
                phoneNo = phoneNo,
                email = email
            });
            
        }
    }
}
