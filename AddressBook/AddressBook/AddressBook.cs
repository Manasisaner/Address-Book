using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
public  class AddressBook
    {

        List<Contact> addContact = new List<Contact>();
        Dictionary<string, List<Contact>> myDict = new Dictionary<string, List<Contact>>();


    }
    public void AddContact()
    {

        Console.WriteLine("Enter the Address Details");
        Console.WriteLine("1-FirstName 2-LastName 3-Address 4-City 5-State 6-Zip 7-PhoneNumber 8-Email");

        Contact contact1 = new Contact()
        {

            FirstName = Console.ReadLine(),

            LastName = Console.ReadLine(),

            Address = Console.ReadLine(),

            City = Console.ReadLine(),

            State = Console.ReadLine(),

            Zip = Convert.ToInt32(Console.ReadLine()),

            PhoneNumber = Convert.ToInt64(Console.ReadLine()),

            Email = Console.ReadLine(),

        };


        Contact contact2 = new Contact()
        {
            FirstName = "Tomeshwar",

            LastName = "Sahu",

            Address = "Bhilai",

            City = "Mysuru",

            State = "Banglore",

            Zip = 490020,

            PhoneNumber = 82828883837,

            Email = "tomeshwar@com",

        };

        Contact contact3 = new Contact()
        {
            FirstName = "Govind",

            LastName = "Bhatt",

            Address = "Bhilai",

            City = "Mumbai",

            State = "Maharasta",

            Zip = 490021,

            PhoneNumber = 82828883837,

            Email = "govind@gmail.com",

        };
        addContact.Add(contact1);
        addContact.Add(contact2);
        addContact.Add(contact3);
    }
}
