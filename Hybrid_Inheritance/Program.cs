using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hybrid_Inheritance
{
    //Single Inheritance
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Dog is barking");
        }
    }
    //Multiple Inheritance
    public interface IFly
    {
        void Fly();
    }
    public class Eagle : Animal, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Bird is flying");
        }

        public void Hunt()
        {
            Console.WriteLine("Eagle is hunting");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Single Inheritance
            Dog dog = new Dog();
            dog.Eat();

            //Multiple-Inheritance
            Eagle eagle = new Eagle();
            eagle.Hunt();
            eagle.Fly();
            Console.ReadKey();
        }
    }
}
