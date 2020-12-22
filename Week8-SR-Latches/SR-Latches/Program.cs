using LogicCircuit.Gates.Composite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Latches
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Insert two values for the latches");
            //Console.WriteLine("R:");
            //string R = Console.ReadLine();
            //Console.WriteLine("S:");
            //string S = Console.ReadLine();

            string path = @"C:\Data\data.txt";
            exist(path);
            var truthTableInputs = Storage.ReadTruthTableData(path);
            string answer = @"C:\Data\answer.txt";
            FileStream fs = File.Create(@"C:\Data\answer.txt");
            fs.Close();
            foreach (var input in truthTableInputs)
            {
                Console.WriteLine("For the next inputs");
                Console.WriteLine($"   R      S      Q    -Q");
                Console.WriteLine($"{input.A}, {input.X}, {input.D}, {input.R}");
                Latches(input, answer);
                Console.WriteLine("");
            }
            Console.ReadKey();
        }

        private static void exist(string path)
        {
            if (!File.Exists(path))
            {
                Console.WriteLine("File does not exist");
            }
        }

        public static void Latches( TruthTable data, string fs)
        {
            TextWriter tw = File.AppendText(fs);
            bool newQ = MyLogicGatesXOR(data.A, data.D);
            bool newNQ = MyLogicGatesXOR(data.X, data.R);
            int q = Utility.ConvertToBit(newQ);
            int nq = Utility.ConvertToBit(newNQ);
            int A = Utility.ConvertToBit(data.A);
            int X = Utility.ConvertToBit(data.X);
            string answer = $"{A},{X},{q},{nq}";
            tw.WriteLine(answer);
            Console.WriteLine($"answers : ");
            Console.WriteLine($"{data.A}, {data.X}, {newQ} , {newNQ}");
            Console.WriteLine("");
            tw.Close();

        }
        private static bool MyLogicGatesXOR(bool a, bool b)
        {
            var logicCircuitXOR = new XOR();
            logicCircuitXOR.InputA.State = a;
            logicCircuitXOR.InputB.State = b;
            var output = logicCircuitXOR.Output.State;
            return output;
        }
        public static FileStream createFile()
        {
            FileStream fs = File.Create(@"C:\Data\answer.txt");

            return fs;
        }
    }
}
