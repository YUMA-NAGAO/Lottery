using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Lottery
{
	public class CalcData
	{
		protected ClassData m_classData;
		protected Random m_random;
		protected List<Student> m_studentList;

		/* コンストラクタ */
		public CalcData(ref int eCheck)
		{
			m_classData = new ClassData("../../ClassDataCSV/class2.csv", ref eCheck);
			if (eCheck == 0)
			{
				m_studentList = m_classData.getStudentList();
			}
			m_random = new System.Random();
		}

		/* 生徒名のリスト取得 (ルーレット表示用) */
		public List<string> getStudentNameList()
		{
			List<string> studentNameList = new List<string>();
			foreach (Student s in m_studentList)
			{
				studentNameList.Add(s.getName());
			}
			return studentNameList;
		}

		/* 生徒選択メソッド (通常モード) */
		public string getDefaultStudentName()
		{
			List<Student> falseList = new List<Student>();
			resetFlg();

			// flgで絞る
			foreach (Student s in m_studentList)
			{
				if (s.getFlg() == false)
				{
					falseList.Add(s);
				}
			}

			return getRandStudent(falseList).getName();
		}

		/* 入力リストからランダムに1名の生徒データを取得 (生徒選択共通メソッド - 1) */
		public Student getRandStudent(List<Student> in_List)
		{
			int sNum = m_studentList.IndexOf(in_List[m_random.Next(0, in_List.Count)]);
			m_studentList[sNum].setFlg(true);
			return m_studentList[sNum];
		}

		/* 全員指名されていたらflgをリセット (生徒選択共通メソッド - 2) */
		public void resetFlg()
		{
			bool b = false;
			foreach (Student s in m_studentList)
			{
				if (s.getFlg() == false)
				{
					b = true;
				}
			}
			if (b == false)
			{
				MessageBox.Show("全生徒が指名されました。" + Environment.NewLine + "リセットして抽選を再開します。");
				foreach (Student s in m_studentList)
				{
					s.setFlg(false);
				}
			}
		}

		/* 名前から生徒データを逆引き (汎用メソッド - 1) */
		protected List<Student> SearchStudentName(string in_name)
		{
			List<Student> temp = new List<Student>();
			foreach (Student s in m_studentList)
			{
				if (string.Compare(in_name, s.getName()) == 0)
				{
					temp.Add(s);
				}
			}
			return temp;
		}

		/* 誕生日から生徒データを逆引き (汎用メソッド - 2) */
		protected List<Student> SearchStudentBirth(DateTime in_bt1, DateTime in_bt2)
		{
			List<Student> temp = new List<Student>();
			foreach (Student s in m_studentList)
			{
				if (in_bt1.Date <= s.getBirth().Date && s.getBirth().Date <= in_bt2.Date)
				{
					temp.Add(s);
				}
			}
			return temp;
		}

		/* 出席番号から生徒データを逆引き (汎用メソッド - 3) */
		protected Student SearchStudentNum(string in_num)
		{
			foreach (Student s in m_studentList)
			{
				if (string.Compare(in_num, s.getNum()) == 0)
				{
					return s;
				}
			}
			return null;
		}
	}

}