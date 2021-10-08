using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookMain
{
    class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public int zip { get; set; }
        public long phoneNo { get; set; }
        public string email { get; set; }

        /// <summary>
        /// To display the  user details when we print the user object 
        /// EX.console.writeLine(anyuserObject);
        /// </summary>
        /// <returns></returns>
       /* public override string ToString()
        {
            return "FirstName :"+ this.firstName + " LastName :"+ this.lastName + "Address : " + this.address + " City :" + this.city + "State : " + this.state + "Zip= " + this.zip + "PhoneNumber= " + this.phoneNo + "Email= " + this.email + "\n";
        }*/

    }    
}
