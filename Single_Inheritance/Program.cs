using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Inheritance
{
    public class Parent
    {
        public void Animal()
        {
            Console.WriteLine("This is an Animal");
        }
    }
    public class Child : Parent
    {
        public void Elephant()
        {
            Console.WriteLine("This is an Elephant");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.Animal();
            obj.Elephant();
            Console.ReadKey();
        }
    }
}
