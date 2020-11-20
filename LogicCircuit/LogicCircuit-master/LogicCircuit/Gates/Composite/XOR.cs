﻿using LogicCircuit.Abstractions.Gates;
using LogicCircuit.Gates.Simple;
using LogicCircuit.Infrastructure;

namespace LogicCircuit.Gates.Composite
{
    public class XOR : IInput2Output1
    {
        private readonly OR or = new OR();
        private readonly AND and = new AND();
        private readonly NOT not = new NOT();
        private readonly AND outputAnd = new AND();

        public InputPin InputA { get { return or.InputA; } }
        public InputPin InputB { get { return or.InputB; } }
        public OutputPin Output { get { return outputAnd.Output; } }

        public XOR()
        {
            SetupDetectBothInputHigh();

            //If either one of them is on
            SetupDetectAnyInputHigh();

            //Both may not be on and 1 of them must be on to be on
            SetupDetectOnlyOneInputHigh();
        }

        private void SetupDetectBothInputHigh()
        {
            InputA.ConnectTo(and.InputA);
            InputB.ConnectTo(and.InputB);
            and.Output.ConnectTo(not.InputA);
        }

        private void SetupDetectAnyInputHigh()
        {
            InputA.ConnectTo(or.InputA);
            InputB.ConnectTo(or.InputB);
        }

        private void SetupDetectOnlyOneInputHigh()
        {
            outputAnd.InputA.ConnectTo(not.Output);
            outputAnd.InputB.ConnectTo(or.Output);
        }
    }
}
