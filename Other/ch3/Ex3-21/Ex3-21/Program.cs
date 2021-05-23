using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int t, h, m, s;
            Console.Write("시간을 입력하세요.(ex>102530) : ");
            t = int.Parse(Console.ReadLine());
            h = t / 10000;
            m = (t / 100) % 100;
            s = t % 100;
            Console.WriteLine("{0}시 {1}분 {2}초",h,m,s);
        }
    }
}
