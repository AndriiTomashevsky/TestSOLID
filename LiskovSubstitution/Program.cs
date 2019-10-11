using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
        public interface IEmployeeDetails
        {
            string GetEmployeeDetails(int id);
        }

        public interface IWorkDetails
        {
            string GetWorkDetails(int id);
        }

        public abstract class Employee
        {
            public virtual string GetWorkDetails(int id)
            {
                return "Base Work";
            }

            public virtual string GetEmployeeDetails(int id)
            {
                return "Base Employee";
            }
        }

        public class SeniorEmployee : IEmployeeDetails, IWorkDetails
        {
            public string GetWorkDetails(int id)
            {
                return "Senior Work";
            }

            public string GetEmployeeDetails(int id)
            {
                return "Senior Employee";
            }
        }

        public class JuniorEmployee : IEmployeeDetails
        {





            public string GetEmployeeDetails(int id)
            {
                return "Junior Employee";
            }
        }

        static void Main(string[] args)
        {
            List<IWorkDetails> workDetails = new List<IWorkDetails>();
            List<IEmployeeDetails> employeeDetails = new List<IEmployeeDetails>();
            employeeDetails.Add(new JuniorEmployee());
            workDetails.Add(new SeniorEmployee());
            foreach (IWorkDetails emp in workDetails)
            {
                Console.WriteLine(emp.GetWorkDetails(985));
            }

            foreach (IEmployeeDetails emp in employeeDetails)
            {
                Console.WriteLine(emp.GetEmployeeDetails(985));
            }

            Console.ReadKey();
        }
    }
}
