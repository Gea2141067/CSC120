using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR_Latches
{
    class Storage
    {
        static string STORAGE = "MyStore.txt";
        public static bool SaveData(int val)
        {
            var fs = new FileStream(STORAGE, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.Write(val);
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



        public static bool SaveTruthTableData(int val1, int val2, int val3, int result)
        {
            var fs = new FileStream(STORAGE, FileMode.Create);
            var sw = new StreamWriter(fs);
            sw.WriteLine($"{val1}, {val2}, {val3}, {result}");
            sw.Flush();
            sw.Close();
            fs.Close();
            return true;
        }

        public static bool SaveTruthTableData(TruthTable tt)
        {

            return SaveTruthTableData(
                                        tt.A ? 1 : 0,
                                        tt.X ? 1 : 0,
                                        tt.D ? 1 : 0,
                                        tt.R ? 1 : 0
                                        );
        }
        public static TruthTable ReadTruthTable()
        {
            var inputRow = new TruthTable();
            if (!File.Exists(STORAGE))
            {
                return inputRow;
            }
            var data = File.ReadAllText(STORAGE);
            var dataElements = data.Split(','); // 0,1,0,1  will be split into arrays

            inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
            inputRow.X = Utility.ConvertToBoolean(dataElements[1]);
            inputRow.D = Utility.ConvertToBoolean(dataElements[2]);
            inputRow.R = Utility.ConvertToBoolean(dataElements[3]);
            return inputRow;
        }
        public static List<TruthTable> ReadTruthTableData(string dataPath)
        {
            var inputList = new List<TruthTable>();
            var sr = new StreamReader(dataPath);
            string line;
            while ((line = sr.ReadLine()) != null) // peek and read till End of File
            {

                var inputRow = new TruthTable();
                var dataElements = line.Split(',');

                inputRow.A = Utility.ConvertToBoolean(dataElements[0]);
                inputRow.X = Utility.ConvertToBoolean(dataElements[1]);
                inputRow.D = Utility.ConvertToBoolean(dataElements[2]);
                inputRow.R = Utility.ConvertToBoolean(dataElements[3]);
                inputList.Add(inputRow);
            }

            sr.Close();

            return inputList;
        }
    }
}
