using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Latches
{
    class Utility
    {
        public static Boolean ConvertToBoolean(string data)
        {
            return (data == "1" ? true : false);
        }

        public static int ConvertToBit(Boolean data)
        {
            return Convert.ToInt16(data);
        }
    }
}
