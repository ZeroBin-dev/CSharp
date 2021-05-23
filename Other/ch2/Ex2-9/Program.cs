using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_9
{
    enum Color {RED=100,GREEN,BLUE};
    class Program
    {
        static void Main(string[] args)
        {
            Color c = Color.RED;
            c++;
            int i = (int)c;
            Console.WriteLine(c+" : "+i);
            Console.WriteLine("{0} : {1}", c, i);
        }
    }
}
