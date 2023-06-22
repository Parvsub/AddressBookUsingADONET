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

            //Retrieve Operation
            Contact retrievedContact = addressBook.GetContact(2);
            if (retrievedContact != null)
            {
                Console.WriteLine($"Contact id :{retrievedContact.ContactId}");
                Console.WriteLine($"Contact FirstName: {retrievedContact.FirstName}");
                Console.WriteLine($"Contact LastName: {retrievedContact.LastName}");
                Console.WriteLine($"Contact Email: {retrievedContact.Email}");
                Console.WriteLine($"Contact City: {retrievedContact.City}");
                Console.WriteLine($"Contact state : {retrievedContact.State}");
            }
            else
            {
                Console.WriteLine("Employee not found.");
            }
        }
    }
}