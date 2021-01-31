using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lottery
{
    public partial class Form1 : Form
    {
        private string student_name = "山田太郎";
        private int student_number = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void GatyaButtonClicked(object sender, EventArgs e)
        {
            this.result.Text = student_name;
        }

        private void NomalChecked(object sender, EventArgs e)
        {
			// student_name = "森田盛岡";
			CalcData cldata = new CalcData();
			student_name = cldata.getRandStudentName();

		}

        private void BirthdayChecked(object sender, EventArgs e)
        {
            student_name = "川上雷";

        }

        private void Nomal_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
