using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_management
{
    internal class Adress
    {
        public contact AddContact()
        {
            contact contact = new contact();
            Console.WriteLine("Enter your First Name");
            contact.FirstName = Console.ReadLine();
            Console.WriteLine("Enter your Last Name");
            contact.LastName = Console.ReadLine();
            Console.WriteLine("Enter your Address ");
            contact.Adress = Console.ReadLine();
            Console.WriteLine("Enter your City name ");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State name");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your zipcode");
            contact.zipCode = Console.ReadLine();
            Console.WriteLine("Enter your Phone number");
            contact.phonenumbur = Console.ReadLine();
            Console.WriteLine("Enter your email ");
            contact.email = Console.ReadLine();

            return contact;
        }
    }
}
