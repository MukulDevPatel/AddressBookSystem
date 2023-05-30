using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class AddressBookMain
    {
        private List<Contact> people; 
        public AddressBookMain()
        {
            people = new List<Contact>();
        }

        //Add new contacts and check duplicate if is it exist
        public void addPerson(Contact contact)
        {
            if (!people.Contains(contact))
            {
                people.Add(contact);
                Console.WriteLine("Add Successfully");
            }
            else
            {
                Console.WriteLine($"Duplicate entry deatails \nFirstName: {contact.FirstName}, LastName: {contact.LastName}, Address: {contact.Address}," +
                    $" City: {contact.City}, State: {contact.State}, Zip: {contact.Zip}, PhoneNumber: {contact.PhoneNumber}, Email: {contact.Email}");
            }
        }

        //Search person by their First name
        public void searchPersonByName(string name)
        {
            Contact getPerson = people.FirstOrDefault(p => p.FirstName == name);
            if (getPerson != null)
            {
                Console.WriteLine($"Get the details of Person: {getPerson.FirstName}");
            }else
            {
                Console.WriteLine("Person not found");
            }
        }
    }
}
