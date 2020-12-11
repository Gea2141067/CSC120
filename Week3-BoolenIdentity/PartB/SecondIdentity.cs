using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class SecondIdentity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool Validate()
        {
            var logicCircuitNOTD = new NOT();
            var logicCircuitNOTA = new NOT();
            var logicCircuitAND = new AND();
            logicCircuitNOTD.SetInputA(SetInputD);
            logicCircuitNOTA.SetInputA(SetInputA);
            logicCircuitAND.SetInputA(logicCircuitNOTD);
            logicCircuitAND.SetInputB(logicCircuitNOTA);
            return logicCircuitAND.Output;
        }
    }
}
