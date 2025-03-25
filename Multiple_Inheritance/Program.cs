using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Multiple_Inheritance
{
    public class BaseClass
    {
        public void Animal()
        {
            Console.WriteLine("Animal");
        }
    }
    public interface IFly
    {
       void Fly();
    }
    public class DerivedClass : BaseClass, IFly
    {
        public void Eagle()
        {
            Console.WriteLine("Eagle");
        }
        public void Fly()
        {
            Console.WriteLine("Flying");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            DerivedClass obj = new DerivedClass();
            obj.Eagle();
            obj.Fly();
            Console.ReadKey();
        }
    }
}
