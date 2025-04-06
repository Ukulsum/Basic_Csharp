using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace DefaultCons
{
    // Default Constructor
    public class DefaultCosstructor
    {
        public DefaultCosstructor()
        {
            Console.WriteLine("Default Constructor Invoked.");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            DefaultCosstructor defaultCosstructor = new DefaultCosstructor();
            Console.ReadLine();
        }
    }
}
