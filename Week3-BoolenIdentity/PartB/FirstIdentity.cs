using LogicCircuit.Gates.Simple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class FirstIdentity
    {
        public bool SetInputD { get; set; }
        public bool SetInputA { get; set; }
        public bool Validate()
        {
            var logicCircuitNOT = new NOT();
            var logicCircuitOR = new OR();
            logicCircuitOR.SetInputA(SetInputA);
            logicCircuitOR.SetInputB(SetInputD);
            logicCircuitNOT.SetInputA(logicCircuitOR);
            return logicCircuitNOT.Output;

        }
    }
}