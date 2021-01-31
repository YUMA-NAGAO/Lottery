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
        private string student_name;
		// private int student_number = 0;
		CalcData calc_data;
		List<string> StudentNameList;
		public Form1()
        {
			InitializeComponent();
            calc_data = new CalcData();
			StudentNameList = calc_data.getStudentNameList();
		}

        private void GatyaButtonClicked(object sender, EventArgs e)
        {
            this.result.Text = student_name;
        }

        private void NomalChecked(object sender, EventArgs e)
		{
			student_name = calc_data.getRandStudentName();

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
