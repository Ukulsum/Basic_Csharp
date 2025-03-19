using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.console.writeline("welcome to csharp !!");
            //system.console.readline();
            Console.ReadLine();
            Console.WriteLine("welcome to csharp !!");
            Console.ReadLine();
            Console.WriteLine("enter your first name ");
            string fname = Console.ReadLine();
            Console.WriteLine("enter your last name");
            string lname = Console.ReadLine();
            //console.writeline("your name is : " + name);//concatenation syntax
            Console.WriteLine("your first name is : {0}", fname); //placeholder syntax
            Console.WriteLine("your last name is : {0}", lname);
            Console.ReadLine();

            Console.WriteLine("Enter First number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("First Number is: {0}", num1 );
            Console.WriteLine("Enter Second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Second Number is: {0}", num2);
            int sum = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + sum);
            Console.ReadLine();
        }
    }
}
