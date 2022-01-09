using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System
{
    /// <summary>
    /// Ability to search Person in a City
    /// </summary>
    class AddressBook
    {
        private static List<createcontact> contacts = new List<createcontact>();

        private static Dictionary<string, List<createcontact>> addressBook = new Dictionary<string, List<createcontact>>();

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
        public static void SearchCity()
        {
            Console.WriteLine("Please Enter Name of city");
            string city = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.Find(p => p.city.Equals(city));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.firstName, city);
                }
                else
                {

                }
            }
        }
        // method searching person using state name
        public static void SearchState()
        {
            Console.WriteLine("Please Enter Name of State");
            string state = Console.ReadLine();
            foreach (var Details in contacts)
            {
                var person = contacts.FindAll(p => p.state.Equals(state));
                if (person != null)
                {
                    Console.WriteLine("{0} person in the {1}", Details.firstName, state);
                }
                else
                {

                }
            }

        }
    }
}
