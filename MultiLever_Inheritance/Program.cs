using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace MultiLever_Inheritance
{
    public class Grandparent
    {
        public void GrandParentMethod()
        {
            Console.WriteLine("This is the GrandParent Class");
        }
    }
    public class Parent : Grandparent
    {
        public void ParentMethod()
        {
            Console.WriteLine("This is the Parent Class");
        }
    }
    public class Child : Parent
    {
        public void ChildMethod()
        {
            Console.WriteLine("This is the Child Class");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child obj = new Child();
            obj.GrandParentMethod();
            obj.ParentMethod();
            obj.ChildMethod();
            Console.ReadKey();
        }
    }
}
