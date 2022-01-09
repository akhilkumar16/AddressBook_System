using System;

namespace AddressBook_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address_Book_System");
            AddressBook.AddContact();
            AddressBook.Display();
            AddressBook.Edit();
            AddressBook.Display();
            AddressBook.Delete();
            AddressBook.Display();
            AddressBook.AddMultile();
            AddressBook.Display();
        }
    }
}
