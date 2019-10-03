using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation_SharpCorner
{
    public interface ILead
    {
        void CreateSubTask();
        void AssignTask();
        void WorkOnTask();
    }

    public class TeamLead : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }

        public void CreateSubTask()
        {
            //Code to create a sub task  
        }

        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
        }
    }

    public class Manager : ILead
    {
        public void AssignTask()
        {
            //Code to assign a task.  
        }

        public void CreateSubTask()
        {
            //Code to create a sub task.  
        }

        public void WorkOnTask()
        {
            throw new Exception("Manager can't work on Task");
        }
    }

    public class Programmer : ILead
    {
        public void AssignTask()
        {
            throw new Exception("Programmer can't assign Task");
        }

        public void CreateSubTask()
        {
            throw new Exception("Programmer can't create subTask");
        }

        public void WorkOnTask()
        {
            //Code to implement perform assigned task.  
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
