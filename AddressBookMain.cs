using AddressBookSystem;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AddressBookSystem
{
    public class AddressBookMain 
    {
        public static void AddressBook()
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" });
            contacts.Add(new Contact { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City5", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "UK", Zip = "425125" });
            contacts.Add(new Contact { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" });
            contacts.Add(new Contact { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" });
            contacts.Add(new Contact { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" });
            contacts.Add(new Contact { FirstName = "Harry", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" });

            //Sort address book by FirstName
            contacts.Sort();

            //Display the address book
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }

        public static void UseLambdaForSorting()
        {
            List<Contact> contacts = new List<Contact>();

            contacts.Add(new Contact { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" });
            contacts.Add(new Contact { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City5", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "UK", Zip = "425125" });
            contacts.Add(new Contact { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" });
            contacts.Add(new Contact { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" });
            contacts.Add(new Contact { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" });
            contacts.Add(new Contact { FirstName = "Harry", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" });

            //Sorting by lambda method
            contacts.Sort((person1, person2) => person1.FirstName.CompareTo(person2.FirstName));

            //Print 
            foreach (var contact in contacts)
            {
                Console.WriteLine(contact);
            }
        }
    }
}
