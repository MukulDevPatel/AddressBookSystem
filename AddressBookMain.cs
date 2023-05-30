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
                Console.WriteLine($"Duplicate entry deatails \nFirstName: {contact.FirstName}\n");
            }
        }

        //Search person by their First name
        public void searchPersonByName(string name)
        {
            Contact getPerson = people.FirstOrDefault(p => p.FirstName == name);
            if (getPerson != null)
            {
                Console.WriteLine($"Get the details of Person: {getPerson.FirstName}\n");
            }else
            {
                Console.WriteLine("Person not found\n");
            }
        }

        //Count of contact by their City
        public int CountByCity(string city)
        {
            return people.Count(p => p.City.Equals(city));
            
        }

        //Count of contact person by their State
        public int CountByState(string state)
        {
            return people.Count(p => p.State.Equals(state));
            
        }
    }
}
