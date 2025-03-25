using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Method_Overriding
{
    public class BaseClass
    {
        public virtual int Add(int x, int y)
        {
            return x + y;
        }
    }
    public class ChildClass : BaseClass
    {
        public override int Add(int x, int y)
        {
            if(x <= 0 || y <= 0)
            {
                Console.WriteLine("Values could not be less than zero or equals to zero");
                Console.WriteLine("Enter First Number");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Second Number");
                y = Convert.ToInt32(Console.ReadLine());
            } 
            return x + y;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseClass obj = new BaseClass();
            Console.WriteLine("Base class method Add :" + obj.Add(-3, 8));
            ChildClass ochild = new ChildClass();
            Console.WriteLine("Child class method Add :" + ochild.Add(-2, 2));
            Console.ReadLine();
        }
    }
}
