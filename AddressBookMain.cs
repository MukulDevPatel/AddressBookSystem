using AddressBookSystem;
using Microsoft.VisualBasic;
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
        public static void UseFileIO()
        {
            string filePath = @"D:\BridgeLabz Second batch\AddressBookSystem\FileIOText.txt";
            
            Contact contact1 = new Contact { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact2 = new Contact { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City5", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "UK", Zip = "425125" };
            Contact contact3 = new Contact { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" };
            Contact contact4 = new Contact { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" };
            Contact contact5 = new Contact { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };
            Contact contact6 = new Contact { FirstName = "Harry", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };


            //Write to  file:

            List<Contact> contacts = new List<Contact>() { contact1, contact2, contact3, contact4, contact5, contact6 };

            using (StreamWriter fileWriter = new StreamWriter(filePath))
            {

                fileWriter.WriteLine("FirstName, LastName, Address, City, Email, PhoneNumber, State, Zip");
                foreach (var person in contacts)
                {
                    string record = $"First Name:{person.FirstName}, LastName: {person.LastName}, Address: {person.Address}, City:{person.City}, State:{person.State}, Zip:{person.Zip}, PhoneNumber:{person.PhoneNumber}, Email:{person.Email}";
                    fileWriter.WriteLine(record);
                }
                fileWriter.Close();
            }

            //Read to file:

            List<Contact> storedData = new List<Contact>();
            using (StreamReader fileReader = new StreamReader(filePath))
            {
                fileReader.ReadLine();
                while (!fileReader.EndOfStream)
                {
                    string record = fileReader.ReadLine();
                    string[] data = record.Split(',');
                    
                    Contact persons = new Contact()
                    {
                        FirstName = data[0],
                        LastName = data[1],
                        Address = data[2],
                        City = data[3],
                        Email = data[4],
                        PhoneNumber = data[5],
                        State = data[6],
                        Zip = data[7]

                    };
                    storedData.Add(persons);
                }
            }
            foreach (var contact in storedData)
            {
                Console.WriteLine($"\nFirst Name:{contact.FirstName}, LastName: {contact.LastName}, Address: {contact.Address}, City:{contact.City}, State:{contact.State}, Zip:{contact.Zip}, PhoneNumber:{contact.PhoneNumber}, Email:{contact.Email}");
            }
        }
    }
}
