 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayWithLoop
{
    internal class Program
    {
        //int[] num1 = { 25, 10, 20, 15, 40, 50 };
        static void Main(string[] args)
        {

            Console.WriteLine("Arrays  with Loop");
            string[] subjects = new string[] { "Bangla", "English", "Math", "History", "Islam", "Sciences" };
            for (int i = 0; i < subjects.Length; i++)
            {
                Console.WriteLine(subjects[i]);
            }

            string[] Colors = new string[] { "Red", "Orange", "Green", "Blue", "Yellow", "Pink", "Black" };
            foreach (string items in Colors)
            {
                Console.WriteLine(items);
            }

            //int[] num1 = { 25, 10, 20, 15, 40, 50 };
            //Console.WriteLine(num1.Length);

            //int min = num1[0];
            //for(int i = 1; i < num1.Length; i++)
            //{
            //    if(min > num1[i])
            //    {
            //        min = num1[i];
            //    }
            //}

            //Console.WriteLine("Minimum Number is" + min);


        }
    }
}
