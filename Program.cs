using System;

namespace Adress_management
{
    public class Program
    {
        static void Main(string[] args)
        {
            
           Adress obj= new Adress();
            
            while (true)
            {
                Console.WriteLine("Select aan option\n a add new contact\n b view  saved contacts ");
                string input= Console.ReadLine();
                char option = input[0];

                switch(option)
                {
                  case'a':
                        obj.AddContact();
                        break;
                    case 'b':
                        obj.show();
                        break;
                        default: Console.WriteLine("Enter valid input");
                        break;
                        
                       
                        
                        
                }
            }
            
        }
    }
}
