using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_10_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ia = new int[3];
            int[] ib = { 1, 2, 3 };
            int[,] ic = new int[2, 3];
            int[,] id = { {1,2,3 }, {4,5,6 } };

            int[][] arr = new int[3][];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new int[i + 3];
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    arr[i][j] = i * arr[i].Length + j;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(" "+arr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine(ic.Length);

            for (int i = 0; i < ia.Length; i++)
            {
                ia[i] = ib[i];
            }

            for (int i = 0; i < ia.Length; i++)
            {
                Console.Write(ia[i]);
            }
            Console.WriteLine();
        }
    }
}
