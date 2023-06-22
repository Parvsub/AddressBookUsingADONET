namespace AddressBookUsingADONET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
          
            string connectionString = "Data Source=DESKTOP-C5INR9Q;Initial Catalog=AddressBookUsingAdo;Integrated Security=True";
            AddressBook addressBook = new AddressBook(connectionString);
            Contact contact1 = new Contact(1, "Praveen", "Bodapati", "Prav@gmail.com", "Bengaluru", "Karnataka");
            Contact contact2 = new Contact(2, "Mohan", "Reddy", "mohan@gmail.com", "Vizag", "Andhra Pradesh");
            addressBook.AddContact(contact1);
            addressBook.AddContact(contact2);

            //Update Operation

            contact1.State = "Maharashtra";
            contact1.City = "Mumbai";
            addressBook.UpdateContact(contact1);
            Console.WriteLine("Contact updated successfully");
        }
    }
}