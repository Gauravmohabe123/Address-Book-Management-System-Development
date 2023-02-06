using System;
using System.Collections.Generic;
using System.Text;

namespace Adress_management
{
   public class Adress
    {

        List<contact> contacts;
        public Adress()
        {
            contacts = new List<contact>();
        }
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
                contacts.Add(contact);

                return contact;
            }

           public void show()
            {

                if (contacts.Count <= 0)
                {
                    Console.WriteLine("No contacts available");
                }
                else
                {
                    foreach (var contact in contacts)
                    {
                    Console.WriteLine(contact.ToString());
                       

                    }

                }
            }
        
    }
}
