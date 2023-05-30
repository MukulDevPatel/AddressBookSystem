namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            
            AddressBookMain addressBook=new AddressBookMain();

            //Add contacts detail
            Contact contact1 = new Contact() { FirstName = "Vikram", LastName = "Kumar", Address = "section A", City = "Vijay Nager", Email = "vikra@gmail.com", PhoneNumber = "6254354813", State = "Mp", Zip = "425136" };
            Contact contact2 = new Contact() { FirstName = "Chris", LastName = "Pratt", Address = "section B", City = "City1", Email = "chris@gmail.com", PhoneNumber = "6254354513", State = "Kanada", Zip = "425135" };
            Contact contact3 = new Contact() { FirstName = "Daniel", LastName = "Johson", Address = "section C", City = "City2", Email = "daniel@gmail.com", PhoneNumber = "6254654813", State = "Brazil", Zip = "426136" };
            Contact contact4 = new Contact() { FirstName = "Jaya", LastName = "Sahay", Address = "section D", City = "City3", Email = "jaya@gmail.com", PhoneNumber = "6254554813", State = "Maharashtra", Zip = "424136" };
            Contact contact5 = new Contact() { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City14", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };
            Contact contact6 = new Contact() { FirstName = "Emma", LastName = "Stone", Address = "section E", City = "City14", Email = "emma@gmail.com", PhoneNumber = "6254354823", State = "USA", Zip = "425132" };

            addressBook.addPerson(contact1);
            addressBook.addPerson(contact2);
            addressBook.addPerson(contact3);
            addressBook.addPerson(contact4);
            addressBook.addPerson(contact5);
            addressBook.addPerson(contact6);

            //Search a person by First name
            addressBook.searchPersonByName("Emma");
            addressBook.searchPersonByName("Stone");
        }
    }
}
