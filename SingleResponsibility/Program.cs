using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class EmployeeOld
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        /// <summary>
        /// Данный метод добавляет в БД нового сотрудника
        /// </summary>
        /// <param name="em">Объект для вставки</param>
        /// <returns>Результат вставки новых данных</returns>
        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }

        /// <summary>
        /// Отчет по сотруднику
        /// </summary>
        public void GenerateReport(Employee em)
        {
            // Генерация отчета по деятельности сотрудника
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string FullName { get; set; }

        /// <summary>
        /// Данный метод добавляет в БД нового сотрудника
        /// </summary>
        /// <param name="em">Объект для вставки</param>
        /// <returns>Результат вставки новых данных</returns>
        public bool Add(Employee emp)
        {
            // Вставить данные сотрудника в таблицу БД
            return true;
        }
    }

    public class EmployeeReport
    {
        /// <summary>
        /// Отчет по сотруднику
        /// </summary>
        public void GenerateReport(Employee em)
        {
            // Генерация отчета по деятельности сотрудника
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
