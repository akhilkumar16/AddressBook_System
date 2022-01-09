using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBook_System
{
    class AddressBook
    {
        public static List<createcontact> addressBook = new List<createcontact>();

        public static void AddContact()
        {
            Console.WriteLine(" You have to enter your details here. \n");
            int contactsNum = 1;
            while (contactsNum > 0)
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
                Console.Write(" Enter your Zip code : ");
                person.ZipCode = Console.ReadLine();
                Console.Write(" Enter your Phone number : ");
                person.PhoneNunmber = Console.ReadLine();
                Console.Write(" Enter your Email ID : ");
                person.eMail = Console.ReadLine();

                addressBook.Add(person);
                Console.WriteLine("\n {0}'s contact succesfully added", person.firstName);
                contactsNum--;
            }
        }
        public static void Display()
        {
            if (addressBook.Count > 0)
            {
                Console.Write("\n Enter the name of the person to get all the contact details : ");
                string nameKey = Console.ReadLine();
                foreach (createcontact contact in addressBook)
                {
                    if (nameKey.ToLower() == contact.firstName.ToLower())
                    {
                        Console.WriteLine(" First name-->{0}", contact.firstName);
                        Console.WriteLine(" Last name-->{0}", contact.lastName);
                        Console.WriteLine(" Address-->{0}", contact.address);
                        Console.WriteLine(" City-->{0}", contact.city);
                        Console.WriteLine(" State-->{0}", contact.state);
                        Console.WriteLine(" Zip code-->{0}", contact.ZipCode);
                        Console.WriteLine(" Phone number-->{0}", contact.PhoneNunmber);
                        Console.WriteLine(" E-Mail ID-->{0}", contact.eMail);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\n Contact of the person {0} does not exist", nameKey);
                    }
                }
            }
            else
            {
                Console.WriteLine("Your address book is empty");
            }
        }
    }
}
