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
        List<Contact>> addressBook = new List<Contact>();
        public void AddNewDetails()
        {
            Console.Write("Enter first name: ");
            contact.FirstName = Console.ReadLine();
            Console.Write("Enter last name: ");
            contact.LastName = Console.ReadLine();
            Console.Write("Enter Address: ");
            contact.Address = Console.ReadLine();
            Console.Write("Enter City: ");
            contact.City = Console.ReadLine();
            Console.Write("Enter State: ");
            contact.State = Console.ReadLine();
            Console.Write("Enter ZIP: ");
            contact.Zip = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();
            Console.Write("Enter Email: ");
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
        public void DeleteContact()
        {
            Console.Write("Enter a name for delete contact: ");
            string name = Console.ReadLine();
            foreach (var data in addressBook)
            {
               if (data.Equals(name))
                {
                    addressBook.Remove(name);
                }
            }
        }
        public void Display()
        {
            foreach (var data in addressBook)
            {

                Console.WriteLine(contact.FirstName + "\n" + contact.LastName + "\n" + contact.Address + "\n" + contact.City + "\n" + contact.State + "\n" + contact.Zip + "\n" + contact.PhoneNumber + "\n" + contact.Email);
            }

        }
        public void AddNewPersonDetails()
        {
             Dictionary<string,List<Contact>> addressBooks = new Dictionary<string,List<Contact>>();
            while (true)
            {
                Console.WriteLine("Enter address book name or type 'exit' ");
                string bookName = Console.ReadLine();
                
                if (bookName.ToLower() == "exit")
                { break; }
                
                if (addressBooks.ContainsKey(bookName))
                {
                    Console.WriteLine("{0} Address Book is exist",bookName);
                }
                else { addressBooks.Add(bookName, addressBook);
                    Console.WriteLine("{0} Address book added.\n",bookName);
                    bool flag = true;
                    while (flag) 
                    { 
                        Console.WriteLine("1. Enter person's details \n2. Type 'exit' ");
                        AddressBookMain address = new AddressBookMain();
                        address.AddContact();
                        address.Display();
                        flag = false;
                        break;
                    }
                }
            }
        }
    }
}
