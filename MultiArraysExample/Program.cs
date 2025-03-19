using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiArraysExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 3]; //Declaration of 2D Arrays
            int[,,] arr2 = new int[3, 3, 3]; //Declaration of 3D Arrays
            arr[0, 0] = 5;
            arr[0, 1] = 10;
            arr[0, 2] = 15;
            arr[1, 0] = 20;
            arr[1, 1] = 25;
            arr[1, 2] = 30;
            arr[2, 0] = 35;
            arr[2, 1] = 40;
            arr[2, 2] = 45;


            for(int i = 0; i < 3; i++)
            {
                for (int j = 0; j<3; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();   //new line at each row
            }

            int[,] arr3 = new int[3, 3];
            arr3[0, 1] = 10;
            arr3[1, 2] = 20;
            arr3[2, 0] = 30;
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(arr3[i, j] + "");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Declaration and Initialization at same time");
            Console.WriteLine("There are 3 ways to initialize multidimensional array in C# while declaration.");
            int[,] num = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }; // Declaration and initialization


            for (int i = 0; i < 3; i++)
            {
                for(int j = 0;  j < 3; j++)
                {
                    Console.Write(num[i,j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("We can omit the array size.");
            int[,] num2 = new int[,] { { 123, 234, 345 }, { 321, 432, 543 }, { 543, 654, 765 } };  //Declaration and initialization

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j<3; j++)
                {
                    Console.Write(num2[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.WriteLine("We can omit the new operator also.");
            int[,] num3 = { { 987, 789, 874 }, { 745, 456, 547 }, { 563, 365, 123 } }; //Declaration and initialization
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.Write(num3[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
