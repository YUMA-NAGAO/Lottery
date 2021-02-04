using System;
using System.IO;
using System.Collections.Generic;


namespace Lottery
{
    public class ClassData
    {
        private List<Student> StudentList;

        //コンストラクタ
        public ClassData(string filename, ref int eCheck)
        {
            try
            {
                ReadData(filename);
            }
            catch(Exception)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("Not found " + filename);
            }
        }

        private void ReadData(string filename)
        {
            StreamReader file = null;
            try
            {
                file = new StreamReader(filename);
                StudentList = new List<Student>();

                char[] separator = new char[] { ',', ' ', '　' };
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    string[] data = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    Student tmp = new Student(data[0], data[1], DateTime.ParseExact(data[2], "MM/dd", null));
                    StudentList.Add(tmp);
                }
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }

        //指定位置の生徒のデータを返す
        public List<Student> getStudentList()
        {
            return StudentList;
        }
    }

    public class Student
    {
        private string number, name;
		private DateTime birthday;
		private bool flg;

		public Student(string n, string na, DateTime birth)
        {
            number = n;
            name = na;
			birthday = birth;
			flg = false;
		}
        public string getNum()
        {
            return number;
        }

        public string getName()
        {
            return name;
        }

        public DateTime getBirth()
        {
            return birthday;
        }
		public void setFlg(bool b)
		{
			flg = b;
		}
		public bool getFlg()
		{
			return flg;
		}
    }

}