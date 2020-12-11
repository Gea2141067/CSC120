using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartB
{
    class Program
    {
        static void Main(string[] args)
        {
            // this is the table
            var inputs = new List<IdentityInput>();
            inputs.Add(new IdentityInput() { A = false, D = false});
            inputs.Add(new IdentityInput() { A = false, D = true});
            inputs.Add(new IdentityInput() { A = true, D = false});
            inputs.Add(new IdentityInput() { A = true, D = true});

            Console.WriteLine($"      Y           X           ~(x+y) = ~x.~y");
            foreach (var item in inputs)
            {
                var firstIdentity = new FirstIdentity();
                firstIdentity.SetInputD = item.D;
                firstIdentity.SetInputA = item.A;
                var secondIdentity = new SecondIdentity();
                secondIdentity.SetInputD = item.D;
                secondIdentity.SetInputA = item.A;
                var firstoutput = firstIdentity.Validate();
                var secondoutput = secondIdentity.Validate();
                Console.WriteLine($" D = {firstIdentity.SetInputD}," +
                    $" A = {firstIdentity.SetInputA}, " +
                    $" Output= {firstoutput} = {secondoutput}");
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"      Y           X           ~(x.y) = ~x+~y");
            foreach (var item in inputs)
            {
                var thirdIdentity = new ThirdIdentity();
                thirdIdentity.SetInputD = item.D;
                thirdIdentity.SetInputA = item.A;
                var fourthIdentity = new FourthIdentity();
                fourthIdentity.SetInputD = item.D;
                fourthIdentity.SetInputA = item.A;
                var thirdoutput = thirdIdentity.Validate();
                var fourthoutput = fourthIdentity.Validate();
                Console.WriteLine($" D = {thirdIdentity.SetInputD}," +
                     $" A = {thirdIdentity.SetInputA}, " +
                     $" Output= {thirdoutput} = {fourthoutput}");
            }
                Console.ReadKey();
        }
    }
}
