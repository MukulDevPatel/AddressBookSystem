namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            
            AddressBookMain addressBook=new AddressBookMain();

            //Add contacts detail
            Contact contact8 = new Contact() { FirstName = "Vinay", LastName = "Pathak", Address = "section B3", City = "City2", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425125" };
            Contact contact3 = new Contact() { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" };
            Contact contact4 = new Contact() { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" };
            Contact contact5 = new Contact() { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };
            Contact contact6 = new Contact() { FirstName = "Harry", LastName = "Stone", Address = "section E", City = "City4", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };

            Contact contact1 = new Contact() { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact7 = new Contact() { FirstName = "Saurabh", LastName = "Pratt", Address = "section B", City = "City1", Email = "chris@gmail.com", PhoneNumber = "6254354513", State = "NY", Zip = "425135" };
            Contact contact2 = new Contact() { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City5", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "UK", Zip = "425125" };

            //Entry in address book
            addressBook.addPerson(contact1);
            addressBook.addPerson(contact2);
            addressBook.addPerson(contact3);
            addressBook.addPerson(contact4);
            addressBook.addPerson(contact5);
            addressBook.addPerson(contact6);
            addressBook.addPerson(contact7);
            addressBook.addPerson(contact8);

            //Search a person by First name
            addressBook.searchPersonByName("Emma");
            addressBook.searchPersonByName("Stone");

            //Count by city
            string city = "City3";
            int countCity = addressBook.CountByCity(city);
            Console.WriteLine($"Number of contact persons in {city}: {countCity}");

            //Count by state
            string state = "UK";
            int countState = addressBook.CountByState(state);
            Console.WriteLine($"Number of contact persons in {state}: {countState}");


        }
    }
}
