using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_SharpCorner
{
    public interface ILogger
    {
        void LogMessage(string message);
    }


    public class FileLogger : ILogger
    {
        public void LogMessage(string aStackTrace)
        {
            //code to log stack trace into a file.  
        }
    }

    public class DbLogger : ILogger
    {
        public void LogMessage(string aMessage)
        {
            //Code to write message in database.  
        }
    }

    public class ExceptionLogger
    {
        private ILogger logger;

        public ExceptionLogger(ILogger logger)
        {
            this.logger = logger;
        }

        public void LogException(Exception aException)
        {
            logger.LogMessage(GetUserReadableMessage(aException));
        }

        private string GetUserReadableMessage(Exception ex)
        {
            string strMessage = string.Empty;
            //code to convert Exception's stack trace and message to user readable format.  
            return strMessage;
        }
    }

    public class DataExporter
    {
        public void ExportDataFromFile()
        {
            try
            {
                //code to export data from files to database.  
            }
            catch (IOException ex)
            {
                new ExceptionLogger(new FileLogger()).LogException(ex);
            }
            catch (Exception ex)
            {
                new ExceptionLogger(new DbLogger()).LogException(ex);
            }
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
