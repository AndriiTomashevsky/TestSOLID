using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution_SharpCorner
{
    public interface IWritableSqlFile
    {
        void SaveText();
    }

    public interface IReadableSqlFile
    {
        string LoadText();
    }

    public class ReadOnlySqlFile : IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            /* Code to read text from sql file */
            return "LoadTextReadOnlySQL";
        }
    }

    public class SqlFile : IWritableSqlFile, IReadableSqlFile
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }

        public string LoadText()
        {
            /* Code to read text from sql file */
            return "LoadText";
        }

        public void SaveText()
        {
            /* Code to save text into sql file */
        }
    }

    public class SqlFileManager
    {
        public string GetTextFromFiles(List<IReadableSqlFile> ReadableSqlFiles)
        {
            StringBuilder objStrBuilder = new StringBuilder();

            foreach (var objFile in ReadableSqlFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }

            return objStrBuilder.ToString();
        }

        public void SaveTextIntoFiles(List<IWritableSqlFile> WritableSqlFiles)
        {
            foreach (var objFile in WritableSqlFiles)
            {
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
