using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingADONET
{
    public class AddressBook
    {
        private string connectionString;
        private SqlConnection connection;

        public AddressBook(string connectionString)
        {
            this.connectionString = connectionString;
            connection = new SqlConnection(connectionString);
        }

        public void AddContact(Contact contact)
        {
            try
            {
                connection.Open();
                string insertQuery = "insert into Contact(Contactid , FirstName, LastName, Email, City, State) values (@contactId, @firstname, @lastname, @email, @city, @state)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                insertCommand.Parameters.AddWithValue("@ContactId", contact.ContactId);
                insertCommand.Parameters.AddWithValue("@firstName", contact.FirstName);
                insertCommand.Parameters.AddWithValue("@lastName", contact.LastName);
                insertCommand.Parameters.AddWithValue("@email", contact.Email);
                insertCommand.Parameters.AddWithValue("@city", contact.City);
                insertCommand.Parameters.AddWithValue("@state", contact.State);
                insertCommand.ExecuteNonQuery();
            }
            finally
            {
                connection.Close();
            }
        }

        public void UpdateContact(Contact contact)
        {
            try
            {
                connection.Open();
                string updateQuery = "UPDATE Contact SET FirstName = @firstname, LastName = @lastName, Email = @Email, City = @city, State = @state WHERE Contactid = @contactid";
                SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                updateCommand.Parameters.AddWithValue("@ContactId", contact.ContactId);
                updateCommand.Parameters.AddWithValue("@firstName", contact.FirstName);
                updateCommand.Parameters.AddWithValue("@lastname", contact.LastName);
                updateCommand.Parameters.AddWithValue("@email", contact.Email);
                updateCommand.Parameters.AddWithValue("@city", contact.City);
                updateCommand.Parameters.AddWithValue("@state", contact.State);
                updateCommand.ExecuteNonQuery();

            }
            finally
            {
                connection.Close();
            }
        }

    }
}
