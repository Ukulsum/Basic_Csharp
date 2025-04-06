using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PrivateConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee.GetManager();
            Console.ReadLine();
        }
    }

    public class Employee
    {
        private Employee()
        {

        }
        public static void GetManager()
        {
            Console.WriteLine("Happy");
        }
    }
}
