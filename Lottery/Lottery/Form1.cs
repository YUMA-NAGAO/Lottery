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

		ExCalcData calc_data;
		List<string> StudentNameList;
        Random rnd = new Random();
        int RandomTime = 200;
        //誕生付きの選択肢を保持する変数
        int selectedIndex;
        string selectedItem;
        private int eCheck = 0;   //エラー検出用 0:正常, -1:異常

        public int getErrorCheck()
        {
            return eCheck;
        }

        public async void RandomShowStudent()
        {
            int RandomNum = 0;
             //for文の回数で、時間を決めています。
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
            calc_data = new ExCalcData(ref eCheck);
            if(eCheck == 0)
            {
                StudentNameList = calc_data.getStudentNameList();
                //初期条件で、誕生月の選択肢を、隠すため
                if (Nomal.Checked == true)
                {
                    comboBox1.Visible = false;
                }
            }
            else
            {
                this.Close();
            }
        }

        private void GatyaButtonClicked(object sender, EventArgs e)
        {
            if (Nomal.Checked == true)
            {
                student_name = calc_data.getRandStudentName();
            }
            else if (Birthday.Checked == true)
            {
                student_name = calc_data.getBirthStudentName(selectedIndex);
			}

			if (student_name != null)
			{
				RandomShowStudent();
			}
		}

        private void NomalChecked(object sender, EventArgs e)
		{
            comboBox1.Visible=false;
        }

        private void BirthdayChecked(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedItem = comboBox1.SelectedItem.ToString();
            selectedIndex = comboBox1.SelectedIndex;

        }
    }
}
