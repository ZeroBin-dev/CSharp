using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int @int = 10;
            int i = 20;
            Console.WriteLine(i.GetType());
            Console.WriteLine(@int+i);

            string s = @"test\t1'2'3";
            Console.WriteLine(s);
        }
    }
}
