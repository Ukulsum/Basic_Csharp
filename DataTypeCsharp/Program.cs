using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 25;
            byte b = 0;
            byte c = 255;
            int x = 30;
            int y = 50;
            bool z = a > b;
            float ab = 25.325f;
            float bc = 154.546291f;
            double d = 5235.56231;
            double ad = 324212365.2365419263;
            decimal p = 2.32m;

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);
           
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(z);
            Console.WriteLine(ab);
            Console.WriteLine(bc);
            Console.WriteLine(d);
            Console.WriteLine(ad);
            Console.WriteLine(p);

            Console.WriteLine("STRING AND CHARACTER DATA TYPE");
            string s = "Hello String";
            char cs = 'H';
            string dquot = "\"Double Quotation\"";  //Escape Sequence Double Quot
            string squot = "\'Single Quotation\'";   //Escape Sequence Single Quot
            string bs = "\\Escape Sequence\\";   //Escape Sequence
            string ts = "\tEscape Sequence Tab";   //Escape Sequence
            string tsr = "\t Escape \t Sequence \t Tab"; //Escape Sequence
            string nls = "\nOne\nTwo\nThree";   //Escape Sequence
            string vl = "D:\\Umme\\Csharp\\Tutorials";  //Escape Sequence
            string vls = @"D:\Umme\Csharp\Tutorials";   //Verbatin Literal
            Console.WriteLine(s);
            Console.WriteLine(cs);
            Console.WriteLine( dquot);
            Console.WriteLine(squot);
            Console.WriteLine(bs);
            Console.WriteLine(ts);
            Console.WriteLine(tsr);
            Console.WriteLine(nls);
            Console.WriteLine(vl);
            Console.WriteLine(vls);

            Console.ReadLine();
        }
    }
}
