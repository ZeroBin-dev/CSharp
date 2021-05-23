using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력(1~3) :");
            char c = (char)Console.Read();
            String n = Console.ReadLine();
            //int n = Console.Read() - '0';
            switch(n)
            {
                case "월":
                    Console.WriteLine("월요일");
                    break;
                case "화":
                    Console.WriteLine("화요일");
                    break;
                case "수":
                    Console.WriteLine("수요일");
                    break;
            }
        }
    }
}
