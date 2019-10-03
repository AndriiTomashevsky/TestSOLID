using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_SharpCorner
{
    class Program
    {
        public class UserServiceOld
        {
            SmtpClient _smtpClient;

            public void Register(string email, string password)
            {
                if (!ValidateEmail(email))
                    throw new ValidationException("Email is not an email");
                var user = new User(email, password);

                SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
            }

            public virtual bool ValidateEmail(string email)
            {
                return email.Contains("@");
            }

            public bool SendEmail(MailMessage message)
            {
                _smtpClient.Send(message);
                return true;
            }
        }

        public class UserService
        {
            EmailService _emailService;
            DbContext _dbContext;
            public UserService(EmailService aEmailService, DbContext aDbContext)
            {
                _emailService = aEmailService;
                _dbContext = aDbContext;
            }
            public void Register(string email, string password)
            {
                if (!_emailService.ValidateEmail(email))
                    throw new ValidationException("Email is not an email");
                var user = new User(email, password);
                _dbContext.Save(user);
                _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

            }
        }
        public class EmailService
        {
            SmtpClient _smtpClient;
            public EmailService(SmtpClient aSmtpClient)
            {
                _smtpClient = aSmtpClient;
            }
            public virtual bool ValidateEmail(string email)
            {
                return email.Contains("@");
            }
            public bool SendEmail(MailMessage message)
            {
                _smtpClient.Send(message);
                return true;
            }
        }

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
