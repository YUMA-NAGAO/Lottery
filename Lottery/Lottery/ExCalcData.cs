using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lottery
{
    public class ExCalcData : CalcData
    {
        //コンストラクタ
        public ExCalcData(ref int eCheck) : base(ref eCheck){}

        protected List<DateTime> getMonthStartEnd(int month_index)
        {
            string month_str = (month_index + 1).ToString("D2");
            DateTime dt1 = DateTime.ParseExact(month_str, "MM", null);
            DateTime dt2 = dt1.AddMonths(1).AddDays(-1);
            List <DateTime> days = new List<DateTime>() { dt1, dt2 };
            return days;
        }

        public string getBirthStudentName(int selected_index)
        {
            List<DateTime> days = getMonthStartEnd(selected_index);
            sList = SearchStudentBirth(days[0], days[1]);

			int cnt = 0;
			foreach (Student s in sList)
			{
				if (s.getFlg() == false)
				{
					cnt++;
				}
			}

            if (sList.Count > 0 && cnt > 0)
            {
                string return_name = getRandStudentName();
                sList = cdata.getStudentList();
                return return_name;
			}
			else if (sList.Count > 0 && cnt <= 0)
			{
				sList = cdata.getStudentList();
                MessageBox.Show("誕生月の人を全て当てました。"+ Environment.NewLine +"対象月をかえてください。");
                return null;
            }
            else
            {
				sList = cdata.getStudentList();
                MessageBox.Show("誕生月の人がいませんでした。"+ Environment.NewLine +"対象月をかえてください。");
                return null;
            }
        }
    }
}