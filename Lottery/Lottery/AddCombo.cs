using System;
using System.IO;
using System.Linq;

namespace Lottery
{
    static class AddCombo
    {
        public static string[] DirectroyData(ref int eCheck)
        {
            string dir = "../ClassDataCSV";
            string[] data = { };

            try
            {
                string[] files = Directory.GetFiles(dir, "*.csv");
                int a = 0;
                if (files.Count() != 0)
                {
                    foreach (string s in files)
                    {

                        Array.Resize(ref data, data.Length + 1);
                        data[a] = s.Remove(0, 16);
                        a += 1;

                    }
                }
                else
                {
                    eCheck = -1;
                    ErrorHandling.ErrorPopup("Not found CSV Data");
                }
            }
            catch (Exception)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("Not found ClassDataCSV Folder");
            }

            return data;
        }

    }
}
