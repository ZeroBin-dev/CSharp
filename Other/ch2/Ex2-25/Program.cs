using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int big = 1234567890;
            float f = big;
            Console.WriteLine(f);
            f = (float)big;
            Console.WriteLine(f);
            Console.WriteLine((int)f);
            Console.WriteLine(big-(int)f);

            Console.WriteLine(typeof(string));

            Console.WriteLine("10" is int);
            object obj = "test";
            Console.WriteLine((obj as string));


        }
    }
}
