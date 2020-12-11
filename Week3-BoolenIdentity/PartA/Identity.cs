using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    public class Identity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool SetInputX { get; set; }
        public bool Validate()
        {
            var logicCircuitNOT = new NOT();
            var logicCircuitAND = new AND();
            var logicCircuitOR = new OR();
            logicCircuitNOT.SetInputA(SetInputX);
            logicCircuitAND.SetInputA(logicCircuitNOT);
            logicCircuitAND.SetInputB(SetInputA);
            logicCircuitOR.SetInputA(SetInputD);
            logicCircuitOR.SetInputB(logicCircuitAND);
            return logicCircuitOR.Output;
        }
    }
}
