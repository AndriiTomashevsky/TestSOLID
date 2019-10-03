using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Polymorphic Behavior Through Inheritance (Using virtual-override keyword)
// For testing, remove override keyword 
namespace TestPolymorphism
{
    public class Contact
    {
        public string FirstName { get; set; }

        public virtual string GetDetails()
        {
            return FirstName;
        }
    }

    public class PersonalContact : Contact
    {
        public string BirthDate { get; set; }

        public override string GetDetails()
        {
            return FirstName + " " + BirthDate;
        }
    }

    public class BuisnessContact : Contact
    {
        public string Company { get; set; }

        public override string GetDetails()
        {
            return FirstName + " " + Company;
        }
    }

    class Program
    {
        static string ShowDetails(Contact contact)
        {
            return contact.GetDetails();
        }

        static void Main(string[] args)
        {
            BuisnessContact buisnessContact = new BuisnessContact() { FirstName = "BuisnessName", Company = "testCompany" };
            PersonalContact personalContact = new PersonalContact() { FirstName = "PersonalName", BirthDate = "00.00.0000" };

            Console.WriteLine(ShowDetails(buisnessContact));
            Console.WriteLine(ShowDetails(personalContact));

            Console.ReadKey();
        }
    }
}
