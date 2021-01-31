using System;
using System.IO;
using System.Collections.Generic;


namespace Lottery
{
    public class ClassData
    {
        private List<Student> StudentList;

        //コンストラクタ
        public ClassData(string filename)
        {
            StreamReader file = new StreamReader(filename);
            StudentList = new List<Student>();

            char[] separator = new char[] { ',', ' ', '　' };
            while (!file.EndOfStream)
            {
                String line = file.ReadLine();
                String[] data = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                Student tmp = new Student(data[0], data[1], DateTime.ParseExact(data[2], "MM/dd", null));
                StudentList.Add(tmp);
            }
            file.Close();
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

        public Student(String n, String na, DateTime birth)
        {
            number = n;
            name = na;
            birthday = birth;
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

    }

}