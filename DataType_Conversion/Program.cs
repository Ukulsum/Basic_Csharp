using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 30;
            float b = a;  //Implicit DataType
            Console.WriteLine("Implicit DataType Conversion : " + b);
            int c = (int)b;  ///Explicit DataType
            Console.WriteLine("Explicit DataType Conversion : " + c);
            float d = 20.25f;
            int e = Convert.ToInt32(d);
            Console.WriteLine("Float to integer Data Conversion : " + e);
            string f = "50";
            string g = "60";
            int h = Convert.ToInt32(f) + Convert.ToInt32(g);
            Console.WriteLine(h);
            string i = "50.256";
            string j = "60.325";
            //int k = int.Parse(i) + int.Parse(j);
            float k = float.Parse(i) + float.Parse(j);
            Console.WriteLine(k);
            string l = "50dsf";
            int m = int.Parse(l);
            //Console.WriteLine(m);

            Console.ReadLine();
        }
    }
}
