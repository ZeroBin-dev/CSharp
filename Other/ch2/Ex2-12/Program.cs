using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            string str = "Class Name is : ";
            Console.WriteLine(str+obj.ToString());

            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append(obj.ToString());
            Console.WriteLine(sb);
        }
    }
}
