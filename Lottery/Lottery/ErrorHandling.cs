using System;
using System.Windows.Forms;

namespace Lottery
{
    public static class ErrorHandling
    {
        public static void ErrorPopup(string message)
        {
            MessageBox.Show(message, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}