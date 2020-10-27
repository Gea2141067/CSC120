using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            byte x = 0b_1000; // 2^n

            int b = x >> 5;
            Console.WriteLine($"{Convert.ToString(b, toBase: 2)}");
        }
    }
}
