﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 0d;
            decimal m = 0m;
            for(int i = 0; i < 1000; i++)
            {
                d += 0.10d;
                m += 0.10m;
            }

            Console.WriteLine("d : "+d);
            Console.WriteLine("m : "+m);

        }

    }
}
