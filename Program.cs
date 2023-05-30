namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            
            AddressBookMain addressBook1=new AddressBookMain();
            AddressBookMain addressBook2 = new AddressBookMain();


            //Add contacts detail
            Contact contact1 = new Contact() { FirstName = "Vikram", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact2 = new Contact() { FirstName = "Chris", LastName = "Pratt", Address = "section B", City = "City1", Email = "chris@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425135" };
            Contact contact7 = new Contact() { FirstName = "Ivan", LastName = "Pratt", Address = "section B2", City = "City2", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425125" };
            Contact contact8 = new Contact() { FirstName = "Vinay", LastName = "Pathak", Address = "section B3", City = "City2", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425125" };
            Contact contact3 = new Contact() { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" };
            Contact contact4 = new Contact() { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" };
            Contact contact5 = new Contact() { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City14", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };
            Contact contact6 = new Contact() { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City14", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };

            Contact contact9 = new Contact() { FirstName = "Jay", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact10 = new Contact() { FirstName = "Saurabh", LastName = "Pratt", Address = "section B", City = "City1", Email = "chris@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425135" };
            Contact contact11 = new Contact() { FirstName = "Aarav", LastName = "Pratt", Address = "section B2", City = "City2", Email = "ivan@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425125" };

            //First address book
            addressBook1.addPerson(contact1);
            addressBook1.addPerson(contact2);
            addressBook1.addPerson(contact3);
            addressBook1.addPerson(contact4);
            addressBook1.addPerson(contact5);
            addressBook1.addPerson(contact6);
            addressBook1.addPerson(contact7);
            addressBook1.addPerson(contact8);

            //Second address book
            addressBook2.addPerson(contact9);
            addressBook2.addPerson(contact10);
            addressBook2.addPerson(contact11);

            //Search a person by First name
            addressBook1.searchPersonByName("Emma");
            addressBook1.searchPersonByName("Stone");

            //Search by State
            var SearchInState = new List<Contact>();
            SearchInState.AddRange(addressBook1.searchPersonByState("Kanada"));
            SearchInState.AddRange(addressBook2.searchPersonByState("Kanada"));
            Console.WriteLine("State: Kanada");
            foreach (var people in SearchInState)
            {
                Console.WriteLine($"Name:{people.FirstName}, State:{people.State}");
            }
            
            //Search by City
            var SearchInCity = new List<Contact>();
            SearchInCity.AddRange(addressBook1.searchPersonByCity("City2"));
            SearchInCity.AddRange(addressBook2.searchPersonByCity("City2"));
            Console.WriteLine("City: City2");
            foreach (var people in SearchInCity)
            {
                Console.WriteLine($"Name:{people.FirstName}, City:{people.City}");
            }
        }
    }
}
