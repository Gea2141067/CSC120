using LogicCircuit.Gates.Composite;
using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week2_LogicGates
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is my truth table
           bool[] input = { true, false };

            //This is the testing for AND gate 

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesAND(input[i], input[j]);

            //This is the testing for OR gate

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesOR(input[i], input[j]);

            //This is the testing for NOT gate

            for (int i = 0; i < 2; i++)
                MyLogicGatesNOT(input[i]);

            //This is the testing for NAND gate
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesNAND(input[i], input[j]);

            //This is the testing for NOR gate

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesNOR(input[i], input[j]);

            //This is the testing for XNOR gate
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesXNOR(input[i], input[j]);

            //This is the testing for XOR gate
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    MyLogicGatesXOR(input[i], input[j]);


            Console.ReadKey();

        }

        private static AND MyLogicGatesAND( bool a, bool b)
        {
            // IF both input are true
            var logicCircuitAND = new AND();
            logicCircuitAND.SetInputA(a);
            logicCircuitAND.SetInputB(b);
            var output = logicCircuitAND.Output.State;
            Console.WriteLine(output);
            return logicCircuitAND;
        }
        private static OR MyLogicGatesOR(bool a, bool b)
        {
            // IF both input are true
            var logicCircuitOR = new OR();
            logicCircuitOR.SetInputA(a);
            logicCircuitOR.SetInputB(b);
            var output = logicCircuitOR.Output.State;
            Console.WriteLine(output);
            return logicCircuitOR;
        }
        private static NOT MyLogicGatesNOT(bool a)
        {
            // IF both input are true
            var logicCircuitNOT = new NOT();
            logicCircuitNOT.SetInputA(a);
            var output = logicCircuitNOT.Output.State;
            Console.WriteLine(output);
            return logicCircuitNOT;
        }
        private static NAND MyLogicGatesNAND(bool a, bool b)
        {
            var logicCircuitNAND = new NAND();
            logicCircuitNAND.InputA.State=a;
            logicCircuitNAND.InputB.State=b;
            var output = logicCircuitNAND.Output.State;
            Console.WriteLine(output);
            return logicCircuitNAND;
        }
        private static NOR MyLogicGatesNOR(bool a, bool b)
        {
            var logicCircuitNOR = new NOR();
            logicCircuitNOR.InputA.State = a;
            logicCircuitNOR.InputB.State = b;
            var output = logicCircuitNOR.Output.State;
            Console.WriteLine(output);
            return logicCircuitNOR;
        }
        private static XNOR MyLogicGatesXNOR(bool a, bool b)
        {
            var logicCircuitXNOR = new XNOR();
            logicCircuitXNOR.InputA.State = a;
            logicCircuitXNOR.InputB.State = b;
            var output = logicCircuitXNOR.Output.State;
            Console.WriteLine(output);
            return logicCircuitXNOR;
        }
        private static XOR MyLogicGatesXOR(bool a, bool b)
        {
            var logicCircuitXOR = new XOR();
            logicCircuitXOR.InputA.State = a;
            logicCircuitXOR.InputB.State = b;
            var output = logicCircuitXOR.Output.State;
            Console.WriteLine(output);
            return logicCircuitXOR;
        }
    }

}
