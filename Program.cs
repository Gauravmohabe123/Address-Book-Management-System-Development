using System;

namespace Adress_management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Address Book System");
            Adress obj = new Adress();
            Console.WriteLine(obj.AddContact());
        }
    }
}
