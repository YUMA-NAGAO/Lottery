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
            StreamReader file = null;
            try
            {
                file = new StreamReader(AddCombo.dir + '/' + filename);
                StudentList = new List<Student>();

                char[] separator = new char[] {',','、','.'};
                while (!file.EndOfStream)
                {
                    string line = file.ReadLine();
                    line = line.Replace(" ", String.Empty);
                    line = line.Replace("　", String.Empty);
                    string[] data = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                    Student tmp = null;
                    if (data.Length == 3)
                    {
                        char[] sepSlash = new char[] { '/' };
                        string[] birth = data[2].Split(sepSlash, StringSplitOptions.RemoveEmptyEntries);
                        birth[0] = String.Format("{0:D2}", Int32.Parse(birth[0]));
                        birth[1] = String.Format("{0:D2}", Int32.Parse(birth[1]));
                        tmp = new Student(data[0], data[1], DateTime.ParseExact(birth[0] + '/' + birth[1], "MM/dd", null));
                    }
                    else
                    {
                        tmp = new Student(data[0], data[1], DateTime.ParseExact("01/01", "MM/dd", null));
                    }

                    if (tmp != null)
                    {
                        StudentList.Add(tmp);
                    }
                }
            }
            catch(FileNotFoundException)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("Not found " + filename + "\nChange to another file");
            }
            catch (IOException)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("File may be locked\nChange to another file");
            }
            catch (UnauthorizedAccessException)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("No permission to access this file\nChange to another file");
            }
            catch (Exception)
            {
                eCheck = -1;
                ErrorHandling.ErrorPopup("Error in this file's data format\nChange to another file");
            }
            finally
            {
                if (file != null)
                {
                    file.Close();
                }
            }
        }


        //生徒のリストを返す
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