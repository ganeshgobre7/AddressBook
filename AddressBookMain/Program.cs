using System;

namespace AddressBookMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to the Address Book Program");

            Addressbook addressbook = new Addressbook();
            int defCout = 0;
            while (defCout == 0)
            {
                Console.WriteLine("1:Add Contact  2:Display Contact  3:Edit Contact  4:Delete Contact \n5:Add Multiple Contact 6:Search Person by city and name 7:Write File 8:Read File  9:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressbook.acceptData();
                        //count++;
                        break;
                    case 2:
                        addressbook.displayData();
                        // count++;
                        break;
                    case 3:
                        Console.WriteLine("Enter the FirstName to Change the LastName And City");
                        string fName = Console.ReadLine();
                        string lName = Console.ReadLine();
                        string city = Console.ReadLine();
                        addressbook.edit(fName, lName, city);
                        //count++;
                        break;
                    case 4:
                        Console.WriteLine("Enter the FirstName to delete the contact");
                        string firstName = Console.ReadLine();
                        addressbook.delete(firstName);
                        //  count++;
                        break;
                    case 5:
                        Console.WriteLine("Enter How Many Address You Want to Add");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            addressbook.acceptData();
                        }
                        //count++;
                        break;
                    case 6:
                        Console.WriteLine("Enter the City You Want to Find");
                        string city1 = Console.ReadLine();
                        Console.WriteLine("Enter the State You Want to Find");
                        string state = Console.ReadLine();
                        addressbook.SearchByStateAndCity(city1, state);
                        break;
                    case 7:
                        addressbook.StreamWriteFile();
                        break;
                    case 8:
                        addressbook.StreamReadFile();
                        break;
                    default:
                        Console.WriteLine("Exit");
                        defCout++;
                        break;
                }

            }

        }
    }
    
}