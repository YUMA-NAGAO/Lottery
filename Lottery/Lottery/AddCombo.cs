using System;
using System.IO;

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
                if (files[0] != null)
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
                    ErrorHandling.ErrorPopup("Notfound csv file");
                }
            }
            catch (Exception)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("Not found Data Folder");
            }

            return data;
        }

    }
}
