using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace StaticConstructor
{
    public class StaticConstructor
    {
        static StaticConstructor()
        {
            Console.WriteLine("Static Constructor Invoked.");
        }
        public static void Print()
        {
            Console.WriteLine("Static Print method called.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            StaticConstructor.Print();
            Console.ReadLine();
        }
    }
}
