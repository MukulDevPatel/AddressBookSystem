using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        
        //Override method for check duplicate address by name
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            //Contact otherPerson = (Contact)obj;
            //return string.Equals(FirstName, otherPerson.FirstName, StringComparison.OrdinalIgnoreCase);
            return FirstName.Equals(((Contact)obj).FirstName);
        }
        
    }
}
