using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_ProfWeb
{
    public class Email
    {
        public void Send()
        {
            // код для отправки email-письма
        }
    }

    // Уведомление
    public class Notification
    {
        private Email email;

        public Notification()
        {
            email = new Email();
        }

        public void EmailDistribution()
        {
            email.Send();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
