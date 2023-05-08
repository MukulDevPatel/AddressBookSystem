using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        Contact contact = new Contact();
        public void AddNewDetails()
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
            contact.Zip = Console.ReadLine();
            Console.WriteLine("Enter Phone Number");
            contact.PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter Email");
            contact.Email = Console.ReadLine();

            Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
        }
        public void EditContact()
        {
            Console.WriteLine("Enter option to edit\n1. First Name\n2. Last Name\n3. Address\n4. City\n5. State\n6. ZIP\n7. Phone Number\n8. Email");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.FirstName = Console.ReadLine();
                    break;
                case 2:
                    contact.LastName = Console.ReadLine();
                    break;
                case 3:
                    contact.Address = Console.ReadLine();
                    break;
                case 4:
                    contact.City = Console.ReadLine();
                    break;
                case 5:
                    contact.State = Console.ReadLine();
                    break;
                case 6:
                    contact.Zip = Console.ReadLine();
                    break;
                case 7:
                    contact.PhoneNumber = Console.ReadLine();
                    break;
                case 8:
                    contact.Email = Console.ReadLine();
                    break;
            }
        }
    }
}
