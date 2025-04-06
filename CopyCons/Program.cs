using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CopyCons
{
    public class CopyConstructor
    {
        public string name;
        // Parametrized Constructor
        public CopyConstructor(string name)
        {
            this.name = name;
        }

        // Copy Constructor
        public CopyConstructor(CopyConstructor copy)
        {
            name = copy.name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CopyConstructor cp = new CopyConstructor("Happy");
            CopyConstructor cp1 = new CopyConstructor(cp);

            Console.WriteLine("Name: " + cp1.name);
            Console.ReadLine();
        }
    }
}
