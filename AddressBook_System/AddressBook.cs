using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System
{
    class AddressBook
    {
        public static List<createcontact> contacts = new List<createcontact>();

        public static Dictionary<string, List<createcontact>> addressBook = new Dictionary<string, List<createcontact>>();

        public static void AddTo(string name)
        {
            addressBook.Add(name, contacts);
        }
        public static void AddContact()
        {
            createcontact person = new createcontact();

            Console.Write(" Enter your First name : ");
            person.firstName = Console.ReadLine();
            Console.Write(" Enter your Last name : ");
            person.lastName = Console.ReadLine();
            Console.Write(" Enter your Address : ");
            person.address = Console.ReadLine();
            Console.Write(" Enter your City : ");
            person.city = Console.ReadLine();
            Console.Write(" Enter your State : ");
            person.state = Console.ReadLine();
            Console.Write(" Enter your Zip Code : ");
            person.ZipCode = Console.ReadLine();
            Console.Write(" Enter your Phone Number : ");
            person.PhoneNunmber = Console.ReadLine();
            Console.Write(" Enter your Email-ID : ");
            person.eMail = Console.ReadLine();

            contacts.Add(person);
            Console.WriteLine("\n {0}'s contact succesfully added", person.firstName);
        }

        public static void Details()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Currently there are no people added in your address book.");
            }
            else
            {
                Console.WriteLine("Here is the list and details of all the contacts in your addressbook.");

                foreach (var Detailing in contacts)
                {
                    Console.WriteLine("First name : " + Detailing.firstName);
                    Console.WriteLine("Last name : " + Detailing.lastName);
                    Console.WriteLine("Address : " + Detailing.address);
                    Console.WriteLine("State : " + Detailing.state);
                    Console.WriteLine("City : " + Detailing.city);
                    Console.WriteLine("Zip Code : " + Detailing.ZipCode);
                    Console.WriteLine("Phone number = " + Detailing.PhoneNunmber);
                }
            }
        }
    }
}
