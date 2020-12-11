using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartA
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is the table
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false, X = false });
            inputs.Add(new IdentityInput() { A = false, D = false, X = true  });
            inputs.Add(new IdentityInput() { A = false, D = true , X = false });
            inputs.Add(new IdentityInput() { A = false, D = true , X = true  });
            inputs.Add(new IdentityInput() { A = true , D = false, X = false });
            inputs.Add(new IdentityInput() { A = true , D = false, X = true  }); 
            inputs.Add(new IdentityInput() { A = true , D = true , X = false });
            inputs.Add(new IdentityInput() { A = true , D = true , X = true  });


            foreach (var item in inputs)
            {
                var identity = new Identity();
                identity.SetInputD = item.D;
                identity.SetInputA = item.A;
                identity.SetInputX = item.X;
                var output = identity.Validate();
                Console.WriteLine($" D = {identity.SetInputD}," +
                    $" A = {identity.SetInputA}, " +
                    $" X = {identity.SetInputX}, " +
                    $" Output= {output}");                
            }
            Console.ReadKey();
        }
    }
}
