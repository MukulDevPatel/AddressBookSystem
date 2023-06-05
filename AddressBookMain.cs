using AddressBookSystem;
using Microsoft.VisualBasic;
using System;
using CsvHelper;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Globalization;

namespace AddressBookSystem
{
    public class AddressBookMain 
    {
        public static void UseCSVHelper()
        {
            string filePath = @"D:\BridgeLabz Second batch\AddressBookSystem\CSVHelperText.txt";
            
            Contact contact1 = new Contact { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact2 = new Contact { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City5", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "UK", Zip = "425125" };
            Contact contact3 = new Contact { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" };
            Contact contact4 = new Contact { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" };
            Contact contact5 = new Contact { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };
            Contact contact6 = new Contact { FirstName = "Harry", LastName = "Stone", Address = "section E", City = "City4", Email = "harry@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };


            //Write to  file:
            List<Contact> contacts = new List<Contact>() { contact1, contact2, contact3, contact4, contact5, contact6 };

            StreamWriter fileWriter = new StreamWriter(filePath);
            using (CsvWriter csvWriter = new CsvWriter(fileWriter, CultureInfo.InvariantCulture))
            {
                csvWriter.WriteHeader<Contact>();
                csvWriter.NextRecord();
                csvWriter.WriteRecords<Contact>(contacts);
            }

            //Read to file:

            List<Contact> listOfPeople = new List<Contact>();
            StreamReader fileReader = new StreamReader(filePath);
            CsvReader csvReader = new CsvReader(fileReader, CultureInfo.InvariantCulture);

            csvReader.Read();
            Console.WriteLine(csvReader.ReadHeader());

            listOfPeople = csvReader.GetRecords<Contact>().ToList();
            foreach (Contact contact in listOfPeople)
            {
                Console.WriteLine($"\nFirstName:{contact.FirstName}\tLastName:{contact.LastName}\tAddress:{contact.Address}\tCity:{contact.City}\tState:{contact.State}\tZip:{contact.Zip}\tPhoneNumber:{contact.PhoneNumber}\tEmail:{contact.Email}");
            }
        }
    }
}
