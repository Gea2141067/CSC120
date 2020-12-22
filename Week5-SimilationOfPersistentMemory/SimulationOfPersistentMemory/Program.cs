using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationOfPersistentMemory
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Data\inputdata.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist");
            }
            var truthTableInputs = Storage.ReadTruthTableData(path);

            foreach (var input in truthTableInputs)
            {
                Console.WriteLine($"{input.A}, {input.X}, {input.D}, {input.R}");
            }
            
            Console.ReadKey();
            SimulateMemory();
            Conversion();
            Console.ReadKey();

        }
        private static void Conversion()
        {
            var value = "1";
            var convertedValue = Utility.ConvertToBoolean(value);

            Console.WriteLine($"Conversion from string {value} to binary {convertedValue}");

           
            var bit = Utility.ConvertToBit(convertedValue);
            Console.WriteLine($"Conversion from Boolean {convertedValue} to Bit {bit}");

        }

        private static void SimulateMemory()
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
            for (int i = storedValue; i < 10000; i++)
            {
                Storage.SaveData(a);
                Console.WriteLine($"Print Current Stored Value {i}");
                a = i;
            }

            Console.WriteLine($"Stored Value {a}");
        }
    }
}
