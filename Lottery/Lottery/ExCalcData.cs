using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lottery
{
	public class ExCalcData : CalcData
	{
		/* コンストラクタ */
		public ExCalcData(ref int eCheck) : base(ref eCheck){}

		/* 指定月の日リストを取得 */
		protected List<DateTime> getMonthStartEnd(int month_index)
		{
			string month_str = (month_index + 1).ToString("D2");
			DateTime dt1 = DateTime.ParseExact(month_str, "MM", null);
			DateTime dt2 = dt1.AddMonths(1).AddDays(-1);
			List <DateTime> days = new List<DateTime>() { dt1, dt2 };
			return days;
		}

		/*  生徒選択メソッド (誕生月モード) */
		public string getBirthStudentName(int selected_index)
		{
			List<Student> falseList = new List<Student>();
			resetFlg();

			// 誕生日で絞る
			List<DateTime> days = getMonthStartEnd(selected_index);
			List<Student> tempList = SearchStudentBirth(days[0], days[1]);
			if (tempList.Count == 0)
			{
				MessageBox.Show("誕生月の人がいませんでした。" + Environment.NewLine + "対象月をかえてください。");
				return null;
			}

			// flgで絞る
			foreach (Student s in tempList)
			{
				if (s.getFlg() == false)
				{
					falseList.Add(s);
				}

			}
			if (falseList.Count == 0)
			{
				MessageBox.Show("誕生月の人を全て当てました。" + Environment.NewLine + "対象月をかえてください。");
				return null;
			}

			return getRandStudent(falseList).getName();
		}
	}
}