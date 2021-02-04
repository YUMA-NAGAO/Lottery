using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lottery
{
	public class CalcData
	{
		protected ClassData cdata;
		protected Random r;
		protected List<Student> sList;

		//コンストラクタ
		public CalcData(ref int eCheck)
		{
			cdata = new ClassData("class.csv", ref eCheck);
			if (eCheck == 0)
			{
				sList = cdata.getStudentList();
			}
			r = new System.Random();
		}

		// ランダムに生徒の名前を返す
		public string getRandStudentName()
		{
			List<Student> temp = new List<Student>();
			// まだ当たっていない生徒のリスト作成
			foreach (Student s in sList)
			{
				if (s.getFlg() == false)
				{
					temp.Add(s);
				}
			}
			// 全生徒のflgがtrueになったらリセット
			if (temp.Count <= 0)
			{
				MessageBox.Show("全生徒が指名されました。"+ Environment.NewLine +"リセットして抽選を再開します。");
				foreach (Student s in sList)
				{
					s.setFlg(false);
					temp.Add(s);
				}
			}
			// int rNum = r.Next(0, temp.Count);
			int sNum = sList.IndexOf(temp[r.Next(0, temp.Count)]);
			sList[sNum].setFlg(true);
			return sList[sNum].getName();
		}

		// 生徒名のリストを返す
		public List<string> getStudentNameList()
		{
			List<string> StudentNameList = new List<string>();
			foreach (Student s in sList)
			{
				StudentNameList.Add(s.getName());
			}
			return StudentNameList;
		}

		//名前から生徒データを逆引き
		protected List<Student> SearchStudentName(string na)
		{
			List<Student> temp = new List<Student>();
			foreach (Student s in sList)
			{
				if (string.Compare(na, s.getName()) == 0)
				{
					temp.Add(s);
				}
			}
			return temp;
		}

		//誕生日から生徒データを逆引き
		protected List<Student> SearchStudentBirth(DateTime bt1, DateTime bt2)
		{
			List<Student> temp = new List<Student>();
			foreach (Student s in sList)
			{
				if (bt1.Date <= s.getBirth().Date && s.getBirth().Date <= bt2.Date)
				{
					temp.Add(s);
				}
			}
			return temp;
		}

		//出席番号から生徒データを逆引き
		protected Student SearchStudentNum(string n)
		{
			foreach (Student s in sList)
			{
				if (string.Compare(n, s.getNum()) == 0)
				{
					return s;
				}
			}
			return null;
		}
	}

}