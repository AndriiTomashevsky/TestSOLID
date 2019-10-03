using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Polymorphic Behavior Through Interfaces
namespace TestPolymorphism2
{
    public interface ICountryTaxCalculator
    {
        decimal CalculateTaxAmount();
    }

    public class TaxCalculatorForUS : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 10000m;
        }
    }

    public class TaxCalculatorForUK : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 20000m;
        }
    }

    public class TaxCalculatorForIN : ICountryTaxCalculator
    {
        public decimal CalculateTaxAmount()
        {
            return 5000m;
        }
    }

    class Program
    {
        public static void ShowDetails(ICountryTaxCalculator t)
        {
            decimal tax = t.CalculateTaxAmount();

            Console.WriteLine("Tax Amount : " + tax);
        }

        static void Main(string[] args)
        {
            TaxCalculatorForUS t1 = new TaxCalculatorForUS();
            TaxCalculatorForUK t2 = new TaxCalculatorForUK();
            TaxCalculatorForIN t3 = new TaxCalculatorForIN();

            ShowDetails(t1);
            ShowDetails(t2);
            ShowDetails(t3);

            Console.ReadKey();
        }
    }
}
