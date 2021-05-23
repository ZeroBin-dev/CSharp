using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_29
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double? num2 = null;
            double? num3 = 10.0;

            if(num2.HasValue)
            {
                Console.WriteLine(num2.Value);
            }

            int i = 526;
            object obj = i;     //박싱(정수형이 객체가 됨)
            Console.WriteLine(obj.ToString());

            int n = (int)obj;   //언박싱
            Console.WriteLine(n);
        }
    }
}
