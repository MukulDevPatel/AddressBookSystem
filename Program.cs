namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");
            AddressBookMain addressBook=new AddressBookMain();
            addressBook.AddNewPersonDetails();

        }
    }
}
