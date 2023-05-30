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
        private Dictionary<String, List<Contact>> contactByCity;
        private Dictionary<String, List<Contact>> contactByState;
        public AddressBookMain()
        {
            people = new List<Contact>();
            contactByCity = new Dictionary<String, List<Contact>>();
            contactByState = new Dictionary<String, List<Contact>>();
        }

        //Add persons to Dictionary
        public void AddToDictionary(Dictionary<String, List<Contact>> dict, string key, Contact contact)
        {
            if (dict.ContainsKey(key))
            {
                dict[key].Add(contact);
            }else
            {
                dict[key] = new List<Contact>() { contact };
            }
        }

        //Add new contacts and check duplicate if is it exist
        public void addPerson(Contact contact)
        {
            if (!people.Contains(contact))
            {
                people.Add(contact);
                AddToDictionary(contactByCity, contact.City, contact);
                AddToDictionary(contactByState, contact.State, contact);
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

        //Search person by their City
        public List<Contact> searchPersonByCity(string city)
        {
            return people.Where(p => p.City.Equals(city)).ToList();
            
        }

        //Search person by their State
        public List<Contact> searchPersonByState(string state)
        {
            return people.Where(p => p.State == state).ToList();
            
        }
    }
}
