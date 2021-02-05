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
			int cnt = 0;

            // 全生徒の中でまだ指名されていない人がいるか確認
            foreach (Student s in sList)
			{
				if (s.getFlg() == false)
				{
					cnt++;
				}
			}

            // 全員指名されていたらリセット
			if (cnt <= 0)
			{
				MessageBox.Show("全生徒が指名されました。" + Environment.NewLine + "リセットして抽選を再開します。");
				foreach (Student s in sList)
				{
					s.setFlg(false);
				}
			}

            // 誕生月を絞ってルーレット開始
			sList = SearchStudentBirth(days[0], days[1]);
			cnt = 0;
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