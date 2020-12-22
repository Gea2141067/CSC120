using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memory
{
    public class Storage
    {
        static string STORAGE = "MyStore.txt";
        public static bool SaveData(int val)
        {
            var fs = new FileStream(STORAGE, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Write( val);
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

        public static int ReadData()
        {
            if (!File.Exists(STORAGE))
            {
                return 0;
            }
            var data = File.ReadAllText(STORAGE);
            var inValue = int.Parse(data);
            return inValue;
        }
    }
}
