using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_1
{
    class Point
    {
        int x, y;
        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public void PrintPoint()
        {
            int a = 3;
            Console.WriteLine("("+x+","+y+")");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p = new Point(1, 2);
            p.PrintPoint();
        }
    }
}
