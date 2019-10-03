using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitution
{
    class Program
    {
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

        public class SeniorEmployee : Employee
        {
            public override string GetWorkDetails(int id)
            {
                return "Senior Work";
            }

            public override string GetEmployeeDetails(int id)
            {
                return "Senior Employee";
            }
        }

        public class JuniorEmployee : Employee
        {
            // Допустим, для Junior’a отсутствует информация
            public override string GetWorkDetails(int id)
            {
                throw new NotImplementedException();
            }

            public override string GetEmployeeDetails(int id)
            {
                return "Junior Employee";
            }
        }

        static void Main(string[] args)
        {
            List<Employee> list = new List<Employee>();

            list.Add(new JuniorEmployee());
            list.Add(new SeniorEmployee());

            foreach (Employee emp in list)
            {
                emp.GetEmployeeDetails(985);
            }

            Console.ReadKey();
        }
    }
}
