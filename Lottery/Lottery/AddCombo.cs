using System;
using System.IO;

namespace Lottery
{
    class AddCombo
    {
        public string[] DirectroyData()
        {
            string dir = "../ClassDataCSV";
            string[] files = Directory.GetFiles(dir, "*.csv");
            string[] data = { };
            int a = 0;
            foreach (string s in files)
            {

                Array.Resize(ref data, data.Length + 1);
                data[a] = s.Remove(0,16);
                a += 1;

            }


            return data;
        }

    }
}
