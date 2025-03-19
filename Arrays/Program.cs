using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int arr[] = new int[5]; //Compile time error
            int[] arr = new int[5]; //Creating array
            arr[0] = 11;
            arr[1] = 22;
            arr[2] = 33;

            string[] arr2 = new string[10];
            arr2[0] = "Umme";
            arr2[1] = "Fatime";
            arr2[2] = "Lamiya";


            Console.WriteLine(arr[0]);
            Console.WriteLine(arr[1]);
            Console.WriteLine(arr[2]);
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
            Console.WriteLine(arr2[2]);
            Console.WriteLine(arr2.Length);


            Console.WriteLine("Declaration and Initialization at same time");
            Console.WriteLine("There are 3 ways to initialize array at the time of declaration.");
            int[] arr3 = new int[5] { 12, 19, 26, 90, 104 }; //Declare and initialize one way

            Console.WriteLine(arr3[0]);
            Console.WriteLine(arr3[1]);
            Console.WriteLine(arr3[2]);
            Console.WriteLine(arr3[3]);
            Console.WriteLine(arr3[4]);


            Console.WriteLine("We can omit the size of array.");
            int[] arr4 = new int[] { 15, 23, 62 }; //We can omit the size of array.


            Console.WriteLine(arr4.Length);
            Console.WriteLine(arr4[0]);
            //Console.WriteLine(arr4[3]); //Exception Error


            int[] arr5 = { 85, 89, 63, 52 };

            Console.WriteLine(arr5.Length);
            Console.WriteLine(arr5[3]);

            Console.ReadLine();
        }
    }
}
