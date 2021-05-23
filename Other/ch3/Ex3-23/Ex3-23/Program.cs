using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("123456789");
            Console.WriteLine("{0,-5}",1.2);
            Console.WriteLine("{0,5}",1.2);
            Console.WriteLine("{0,5}", 123.45);

            double d = Math.PI;
            Console.WriteLine("{0:C}",d);
            Console.WriteLine("{0:E}", d);
            Console.WriteLine("{0:F}", d);
            Console.WriteLine("{0:G}", d);
            Console.WriteLine("{0:P}", d);
            Console.WriteLine("{0:R}", d);
            Console.WriteLine("{0:X}", 255);

        }
    }
}
