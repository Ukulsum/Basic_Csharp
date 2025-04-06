using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace ParameterizedConstructor
{
    public class ParaConstructor
    {
        public ParaConstructor(string name)
        {
            Console.WriteLine($"Parameterized Constructor {name}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            ParaConstructor paraConstructor = new ParaConstructor("Robiul Islam");

            Console.ReadLine();
        }
    }
}
