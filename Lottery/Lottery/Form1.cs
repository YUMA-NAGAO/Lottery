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

		CalcData calc_data;
		List<string> StudentNameList;
        Random rnd = new Random();
        int RandomTime = 200;

        public async void RandomShowStudent()
        {
            int RandomNum = 0;
 //           for文の回数で、時間を決めています。
            for (int i = 0; i < RandomTime; i ++)
            {
                RandomNum = rnd.Next(StudentNameList.Count);
                this.result.Text = StudentNameList[RandomNum];
                await Task.Delay(1);
            }

            this.result.Text =student_name;
        }


        public Form1()
        {
			InitializeComponent();
            calc_data = new CalcData();
			StudentNameList = calc_data.getStudentNameList();
		}

        private void GatyaButtonClicked(object sender, EventArgs e)
        {

            RandomShowStudent();
                        
        }

        private void NomalChecked(object sender, EventArgs e)
		{
            comboBox1.Visible=false;
            student_name = calc_data.getRandStudentName();
        }

        private void BirthdayChecked(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
         
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();
            int selectedIndex = comboBox1.SelectedIndex;
        }
    }
}
