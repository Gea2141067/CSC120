using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class FourthIdentity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool Validate()
        {
            var logicCircuitNOTD = new NOT();
            var logicCircuitNOTA = new NOT();
            var logicCircuitOR = new OR();
            logicCircuitNOTD.SetInputA(SetInputD);
            logicCircuitNOTA.SetInputA(SetInputA);
            logicCircuitOR.SetInputA(logicCircuitNOTD);
            logicCircuitOR.SetInputB(logicCircuitNOTA);
            return logicCircuitOR.Output;
        }
    }
}
