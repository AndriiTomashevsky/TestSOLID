using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversion_Metanit
{
    public interface IPrinter
    {
        void Print(string text);
    }

    class Book
    {
        public string Text { get; set; }
        IPrinter printer;

        public Book(IPrinter printer)
        {
            this.printer = printer;
        }

        public void Print()
        {
            printer.Print(Text);
        }
    }

    class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Printer : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(new ConsolePrinter());
            book.Print();

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
