using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Hierarchal_Inheritance
{
    public class Person       //Parent Class
    {
        public void Study()
        {
            Console.WriteLine("Some Persons study Science");
        }
    }
    public class Student : Person   //Child Class 1
    {
        public void Like()
        {
            Console.WriteLine("Student likes Science");
        }
    }
    public class Teacher : Person    //Child Class 2
    {
        public void Love()
        {
            Console.WriteLine("Teacher loves Arts");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Teacher teacher = new Teacher();
            student.Study();
            student.Like();

            teacher.Study();
            teacher.Love();
            Console.ReadKey();
        }
    }
}
