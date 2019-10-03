using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpneClosed_ProfWeb
{
    class Program
    {
        public class EmployeeReportOld
        {
            // <summary>
            /// Тип отчета
            /// </summary>
            public string TypeReport { get; set; }

            /// <summary>
            /// Отчет по сотруднику
            /// </summary>
            public void GenerateReport(Employee em)
            {
                if (TypeReport == "CSV")
                {
                    // Генерация отчета в формате CSV
                }

                if (TypeReport == "PDF")
                {
                    // Генерация отчета в формате PDF
                }
            }
        }

        public class EmployeeReport
        {
            /// <summary>
            /// Метод для создания отчета
            /// </summary>
            public virtual void GenerateReport(Employee em)
            {
                // Базовая реализация, которую нельзя модифицировать
            }
        }

        public class EmployeeCSVReport : EmployeeReport
        {
            public override void GenerateReport(Employee em)
            {
                // Генерация отчета в формате CSV
            }
        }

        public class EmployeePDFReport : EmployeeReport
        {
            public override void GenerateReport(Employee em)
            {
                // Генерация отчета в формате PDF
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

    public class Employee
    {
    }
}
