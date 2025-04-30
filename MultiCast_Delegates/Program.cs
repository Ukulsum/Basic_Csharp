using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MultiCast_Delegates
{
    public delegate void Calculator(int x, int y);
    public class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }

        static void Main(string[] args)
        {
            Calculator calc = new Calculator(Add);
            calc += Mul;
            calc(20, 30);
            Console.ReadLine();
        }
    }
}
