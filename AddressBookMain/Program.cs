using System;

namespace AddressBookMain
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wel-Come to the Address Book Program");
            

            Addressbook addressbook = new Addressbook();

            int count = 0;
            int defCout = 0;
            while(defCout==0)
            {
                Console.WriteLine("1:Add Contact  2:Display Contact  3:Edit Contact  4:Delete Contact 5:Add Multiple Contact 6:Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        addressbook.acceptData();
                        count++;
                        break;
                    case 2:
                        addressbook.displayData();
                        count++;
                        break;
                    case 3:
                        Console.WriteLine("Enter the FirstName to Change the LastName And City");
                        string fName = Console.ReadLine();
                        string lName = Console.ReadLine();
                        string city = Console.ReadLine();
                        addressbook.edit(fName, lName, city);
                        count++;
                        break;
                    case 4:
                        Console.WriteLine("Enter the FirstName to Change the LastName And City");
                        string firstName = Console.ReadLine();
                        addressbook.delete(firstName);
                        count++;
                        break;
                    case 5:
                        Console.WriteLine("Enter How Many Address You Want to Add");
                        int num = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < num; i++)
                        {
                            addressbook.acceptData();
                        }
                        count++;
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
