using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, max = int.MaxValue;
            Console.WriteLine(max);
            unchecked
            {
                i = max + 1;
            }
            try
            {
                checked
                {
                    i = max + 1;
                }
                Console.WriteLine(i);
            }
            catch (OverflowException e)
            {
                Console.WriteLine("예외발생" + e.ToString());
            }
        }
    }
}
