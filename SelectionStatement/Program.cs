using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 20;
            //if(x > 10)
            //{
            //    Console.WriteLine("X is Greater...");
            //}


            //int y = int.Parse(Console.ReadLine());
            //if (y > 10) 
            //{
            //    Console.WriteLine("Y is Greater....");
            //}
            //else
            //{
            //    Console.WriteLine("Y is Lesser...");
            //}

            //string name = Console.ReadLine();
            //if(name == "Umme")
            //{
            //    Console.WriteLine("Welcome to Umme");
            //}
            //else
            //{
            //    Console.WriteLine("Who are you?");
            //}

            //Console.WriteLine("Enter Username : ");
            //string userName = Console.ReadLine();
            //Console.WriteLine("Enter Password");
            //string password = Console.ReadLine();
            //if(userName == "Umme" && password == "umme123")
            //{
            //    Console.WriteLine("Login successfully");
            //}
            //else
            //{
            //    Console.WriteLine(" Incorrect username or password... ");
            //}


            int day = int.Parse(Console.ReadLine());
            if (day == 0)
            {
                Console.WriteLine("Saturday");
            }
            else if (day == 1)
            {
                Console.WriteLine("Sunday");
            }
            else if (day == 2)
            {
                Console.WriteLine("Monday");
            }
            else if(day == 3)
            {
                Console.WriteLine("Tuesday");
            }
            else if(day == 4)
            {
                Console.WriteLine("Wednesday");
            }
            else if(day == 5)
            {
                Console.WriteLine("Thrusday");
            }
            else if(day == 6)
            {
                Console.WriteLine("Friday");
            }
            else
            {
                Console.WriteLine("Unknown");
            }
            Console.ReadLine();
        }
    }
}
