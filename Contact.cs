using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class Contact : IComparable<Contact>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public int CompareTo(Contact other)
        {
            return FirstName.CompareTo(other.FirstName);
        }

        public override string ToString()
        {
            return $"First Name:{FirstName}, LastName: {LastName}, Address: {Address}, " +
                $"City:{City}, State:{State}, Zip:{Zip}, PhoneNumber:{PhoneNumber}, Email:{Email}";
        }
    }
}
