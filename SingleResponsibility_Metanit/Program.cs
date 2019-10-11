using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility_Metanit
{
    interface IPrint
    {
        void Print(string text);
    }

    class PrintPDF : IPrint
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать отчета");
            Console.WriteLine(text);
        }
    }

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

        public void Print(IPrint print)
        {
            print.Print(Text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IPrint printer = new PrintPDF();

            Report report = new Report
            {
                Text = "Hello Wolrd"
            };

            report.Print(printer);

            Console.ReadKey();
        }
    }
}
