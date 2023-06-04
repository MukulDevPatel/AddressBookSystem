namespace AddressBookSystem
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book program");

            Console.WriteLine("Normal sorting");
            AddressBookMain.AddressBook();

            Console.WriteLine("\nSorting By Lambda Method");
            AddressBookMain.UseLambdaForSorting();
        }
    }
}
