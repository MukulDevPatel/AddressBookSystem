using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public static void AddDetails()
        {
            Contact contact = new Contact()
            {
                FirstName = "Mukul",
                LastName = "Patel",
                Address = "Khopli",
                City = "Durg",
                State = "Chhattisgarh",
                Zip = 123456,
                PhoneNumber = 1234567891,
                Email = "patelmukulDev@gamil.com"
            };
            Console.WriteLine(contact.FirstName +"\n" +contact.LastName + "\n"+ contact.Address + "\n"+ contact.City + "\n"+ contact.State + "\n"+ contact.Zip + "\n"+ contact.PhoneNumber + "\n"+ contact.Email);
        }
    }
}
