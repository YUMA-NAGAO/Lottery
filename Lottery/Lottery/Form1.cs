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
        private string student_name="なた";
		// private int student_number = 0;
		CalcData calc_data;
		List<string> StudentNameList;
        Random rnd = new Random();

        public async void RandomShowStudent()
        {
            int RandomNum = 0;
 //           for文の回数で、時間を決めています。
            for (int i = 0; i < 200; i ++)
            {
                RandomNum = rnd.Next(StudentNameList.Count);
                this.result.Text = StudentNameList[RandomNum];
                await Task.Delay(1);
            }
        }


        public Form1()
        {
			InitializeComponent();
            calc_data = new CalcData();
			StudentNameList = calc_data.getStudentNameList();
		}

        private void GatyaButtonClicked(object sender, EventArgs e)
        {
            Console.WriteLine(student_name);
            RandomShowStudent();
            this.result.Text = student_name;
            Console.WriteLine(student_name);
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
