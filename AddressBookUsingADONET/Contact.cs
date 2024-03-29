﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingADONET
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Contact(int contactid, string firstName, string lastName, string email, string city, string state)
        {

            ContactId = contactid;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            City = city;
            State = state;
        }
    }
}