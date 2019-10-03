using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Metanit
{
    class Program
    {
        class Report
        {
            public string Text { get; set; }

            public void GoToFirstPage()
            {
                Console.WriteLine("Переход к первой странице");
            }

            public void GoToLastPage()
            {
                Console.WriteLine("Переход к последней странице");
            }

            public void GoToPage(int pageNumber)
            {
                Console.WriteLine("Переход к странице {0}", pageNumber);
            }

            public void Print()
            {
                Console.WriteLine("Печать отчета");
                Console.WriteLine(Text);
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
