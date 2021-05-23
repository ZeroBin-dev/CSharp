using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_18
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                Console.Write("숫자 입력 : ");
                int n = int.Parse(Console.ReadLine());
                if(n == 0)
                {
                    break;
                }
                else if(n<0)
                {
                    continue;
                }
                int s, i;
                for (i = 1,s = 0; i <= n; ++i)
                {
                    s = s + i;
                }
                Console.WriteLine("n ={0},sum = {1}",n,s);
            }
        }

    }
}
