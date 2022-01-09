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
        public static void Edit()
        {
            Console.Write("\n Enter the first name of the person whom you want to edit the details : ");
            string editKey = Console.ReadLine();
            if (addressBook.Count > 0)
            {
                foreach (createcontact persons in addressBook)
                {
                    if (editKey.ToLower() == persons.firstName.ToLower())
                    {
                        Console.WriteLine("\n Enter the key number for editing the details." +
                            "\n1.First Name " +
                            "\n2.Last Name " +
                            "\n3.Address " +
                            "\n4.City " +
                            "\n5.State " +
                            "\n6.Zipcode " +
                            "\n7.Phone Number " +
                            "\n8.Email ID");
                        Console.Write(" Enter your option : ");
                        int key = Convert.ToInt32(Console.ReadLine());
                        switch (key)
                        {
                            case 1:
                                Console.Write("Enter the new First Name : ");
                                persons.firstName = Console.ReadLine();
                                break;
                            case 2:
                                Console.WriteLine("Enter the new Last name");
                                persons.lastName = Console.ReadLine();
                                break;
                            case 3:
                                Console.Write(" Enter the New Address : ");
                                persons.address = Console.ReadLine();
                                break;
                            case 4:
                                Console.Write(" Enter the New City : ");
                                persons.city = Console.ReadLine();
                                break;
                            case 5:
                                Console.Write(" Enter the New State : ");
                                persons.state = Console.ReadLine();
                                break;
                            case 6:
                                Console.Write("Enter the New Zip Code : ");
                                persons.ZipCode = Console.ReadLine();
                                break;
                            case 7:
                                Console.Write(" Enter the New Phone Number : ");
                                persons.PhoneNunmber = Console.ReadLine();
                                break;
                            case 8:
                                Console.Write(" Enter the New EMail-ID : ");
                                persons.eMail = Console.ReadLine();
                                break;
                            default:
                                Console.WriteLine(" Please enter a valid input");
                                Edit();
                                break;
                        }
                        Console.WriteLine(" {0}'s contact has been successfully added", editKey);
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine(" Your address book is empty");
            }
        }
    }
}
