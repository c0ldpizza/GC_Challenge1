using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            long result = GetPower(8, 3);
            Console.WriteLine(result);

        }

        public static long GetPower(int x, int y)
        {
            long n = x;

            for (int i = 1; i <= y; i++)
            {
                n = n * x;
            }

            return n;
        }

    }
}
