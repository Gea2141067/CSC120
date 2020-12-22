using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var storedValue = Storage.ReadData();
            if (storedValue > 0)
            {
                a = storedValue;
                Console.WriteLine($"Stored Value {a}");
                Console.WriteLine($"Press Any Key to continue");
                Console.ReadLine();
            }
            for( int i = storedValue; i<10000; i++)
            {
                Storage.SaveData(a);
                Console.WriteLine($"Print Current Stored Value {i}");
                a = i;
            }
            
            Console.WriteLine($"Stored Value {a}");
           


        }
    }
}
