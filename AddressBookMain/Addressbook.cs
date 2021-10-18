using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace AddressBookMain
{
    class Addressbook
    {
        
        /*String firstName;
        String lastName;
        String address;
        string city;
        string state;
        int zip;
        long phoneNo;
        string email;*/

        List<User> listUser = new List<User>();//List to store the contact details

        Dictionary<string, User> addressBook = new Dictionary<string, User>();//for multiple address book
        public string Filepath = @"D:\B.LAB\Practice C sharp\AddressBookMain\AddressBookMain\Records.txt";
        /// <summary>
        /// Method to add contact in address book
        /// </summary>
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
        /// <summary>
        /// Method to print the contact without repetation
        /// </summary>
        public void displayData()
        {
            for (int i = 0; i < listUser.Count; i++)
            {
                User user = listUser[i];

                if (!addressBook.ContainsKey(user.firstName))
                {
                    addressBook.Add(user.firstName, user);
                }
                else
                {
                    Console.WriteLine("User= " + user.firstName + " is Already there");
                    
                }
                
            }

            foreach (var i in addressBook) //print the contact
            {
                Console.Write("Your First Name is :");
                Console.WriteLine(i.Key);
                Console.Write("Your Last Name is :");
                Console.WriteLine(i.Value.lastName);
                Console.Write("Your Address is :");
                Console.WriteLine(i.Value.address);
                Console.Write("Your City is :");
                Console.WriteLine(i.Value.city);
                Console.Write("Your State is :");
                Console.WriteLine(i.Value.state);
                Console.Write("Your Zip Code is :");
                Console.WriteLine(i.Value.zip);
                Console.Write("Your Phone Number is :");
                Console.WriteLine(i.Value.phoneNo);
                Console.Write("Your Email is :");
                Console.WriteLine(i.Value.email);
            }
        }
        /// <summary>
        /// Method to Edit the Contact
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="lName"></param>
        /// <param name="city"></param>
        public void edit(string fName, string lName, string city)
        {
            Boolean find = false;
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].firstName.Equals(fName))
                {
                    find = true;
                    listUser[i].lastName = lName;
                    listUser[i].city = city;
                }

            }
            if (find == false)
            {
                Console.WriteLine("Name is Not Exist");
            }
            else
            {
                Console.WriteLine("Name And City Changed");
            }
        }
        /// <summary>
        /// Method to Delete contact
        /// </summary>
        /// <param name="fName"></param>
        public void delete(string fName)
        {
            Boolean find = true;
            for (int i = 0; i < listUser.Count; i++)
            {
                if (listUser[i].firstName.Equals(fName))
                {
                    find = true;
                    listUser.RemoveAt(i);

                }
            }

            if (find == false) 
            {
                Console.WriteLine("Name is Not Exist");
            }
            else
            {
                Console.WriteLine("User Deleted");
            }
        }  
        /// <summary>
        /// Method to serrach person in City  or State
        /// </summary>
        /// <param name="city"></param>
        /// <param name="state"></param>
        public void SearchByStateAndCity(string city ,string state)
        {
            List<User> listUser1 = listUser.FindAll((user) => (user.city.Equals(city) || state.Equals(user.state)));
            foreach(var user in listUser1)
            {
                Console.WriteLine("Name present in  {0} city is : {1}",city,user.firstName);
                Console.WriteLine("Name present in {0} state is : {1}", state, user.firstName);
            }
        }
        public void StreamWriteFile()
        {
            if(File.Exists(Filepath))
            {
                using(StreamWriter sr =File.AppendText(Filepath))
                {
                    foreach(User contacts in listUser )
                    {
                        sr.WriteLine("FirstName :" + contacts.firstName);
                        sr.WriteLine("LastName :" + contacts.lastName);
                        sr.WriteLine("Address :" + contacts.address);
                        sr.WriteLine("City :" + contacts.city);
                        sr.WriteLine("State :" + contacts.state);
                        sr.WriteLine("ZipCode :" + contacts.zip);
                        sr.WriteLine("PhoneNo :" + contacts.phoneNo);
                        sr.WriteLine("Email :" + contacts.email);
                    }
                    sr.Close();
                }

                Console.WriteLine("Data Added in the File");
            }
        }
        public void StreamReadFile()
        {
            if(File.Exists(Filepath))
            {
                using(StreamReader sr=File.OpenText(Filepath))
                {
                    String ContactDetails = "";
                    while((ContactDetails=sr.ReadLine())!=null)
                    {
                        Console.WriteLine((ContactDetails));
                    }
                }
            }
            else
            {
                Console.WriteLine("No Such File Exist");
            }
        }
    }
}
