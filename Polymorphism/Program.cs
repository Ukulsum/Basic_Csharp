using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Polymorphism
{
    public class Polymorphism_Demo
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public string Add(string x, string y)
        {
            return x + y;
        }
    }




    public class MethodOverloading
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c; 
        }

        public double Add (double a, double b, int c)
        {
            return a + b + c;
        } 
        public double Add(double a, int c, double b)
        {
            return a + b + c;
        }
    }


    internal class Program
    { 
        static void Main(string[] args)
        {
            Polymorphism_Demo obj = new Polymorphism_Demo();
            int i= obj.Add(50, 60);
            string str = obj.Add("Interview ", "Happy");
            Console.WriteLine(i + " - " + str);
            Console.ReadLine();
        }
    }
}
