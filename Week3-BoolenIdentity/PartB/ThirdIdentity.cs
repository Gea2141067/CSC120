using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class ThirdIdentity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool Validate()
        {
            var logicCircuitNOT = new NOT();
            var logicCircuitAND = new AND();
            logicCircuitAND.SetInputA(SetInputA);
            logicCircuitAND.SetInputB(SetInputD);
            logicCircuitNOT.SetInputA(logicCircuitAND);
            return logicCircuitNOT.Output;
        }
    }
}
