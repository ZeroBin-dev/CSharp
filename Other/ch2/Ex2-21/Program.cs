using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            double d = 1.2;
            i = (int)d;
            Console.WriteLine("i = {0},d = {1}",i,d);

            int x = 10;
            int y = 20;

            x *= y+1; // x = x*(y+1)
            Console.WriteLine(x);

            int a, b, c, max;
            Console.Write("Enter three numbers : ");
            a = Console.Read() - '0';
            b = Console.Read() - '0';
            c = Console.Read() - '0';
            max = a > b ? a : b;
            max = c > max ? c : max;
            Console.WriteLine("max = "+max);
        }
    }
}
