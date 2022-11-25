using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");
            List<Contacts> Addressbook = new List<Contacts>();
            Contacts contact = new Contacts();
            Console.WriteLine("Add a New Contact:");
            Console.WriteLine("Enter your first_name");
            contact.First_Name = Console.ReadLine();
            Console.WriteLine("Enter your last_name");
            contact.Last_Name = Console.ReadLine();
            Console.WriteLine("Enter your Present_address");
            contact.Present_Address = Console.ReadLine();
            Console.WriteLine("Enter your City");
            contact.City = Console.ReadLine();
            Console.WriteLine("Enter your State");
            contact.State = Console.ReadLine();
            Console.WriteLine("Enter your Email_Id");
            contact.Email_Id = Console.ReadLine();
            Console.WriteLine("Enter your Phone_Number");
            contact.Phone_Number = Console.ReadLine();
            Console.WriteLine("Enter your ZipCode");
            contact.Zip = Console.ReadLine();
            Addressbook.Add(contact);



        }

    }
}

