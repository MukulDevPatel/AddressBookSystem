using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        public void AddDetails()
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
        }
        public static void AddNewDetails()
        {
            Contact contact = new Contact();
            Console.WriteLine("Enter first name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter Address");
            contact.Address = Console.ReadLine();
            Console.WriteLine("Enter City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter ZIP");
            contact.Zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
    }
}
