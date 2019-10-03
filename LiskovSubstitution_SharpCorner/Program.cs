using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_SharpCorner
{
    public class SqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public virtual string LoadText()
        {
            /* Code to read text from sql file */
            return "LoadText";
        }

        public virtual void SaveText()
        {
            /* Code to save text into sql file */
        }
    }

    public class ReadOnlySqlFile : SqlFile
    {
        public override string LoadText()
        {
            /* Code to read text from sql file */
            return "LoadTextReadOnlySQL";
        }

        public override void SaveText()
        {
            /* Throw an exception when app flow tries to do save. */
            throw new IOException("Can't Save");
        }
    }

    public class SqlFileManager
    {
        public List<SqlFile> lstSqlFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();

            foreach (var objFile in lstSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }

            return objStrBuilder.ToString();
        }

        public void SaveTextIntoFiles()
        {
            foreach (var objFile in lstSqlFiles)
            {
                //Check whether the current file object is read only or not.If yes, skip calling it's  
                // SaveText() method to skip the exception.  
                if (!(objFile is ReadOnlySqlFile))
                    objFile.SaveText();
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
