using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_4
{
    class Local
    {
        public static int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            int x = (Local.x = 2) * 2;
            Console.WriteLine("static : " + Local.x);
            Console.WriteLine("local : " + x);
        }
    }
}
