using System;
using System.IO;
using System.Collections.Generic;

namespace Lottery
{
    public class CalcData
    {
        int rvalue;
        ClassData cdata;
        Random r;
        List<Student> sList;

        //コンストラクタ
        public CalcData()
        {
            cdata = new ClassData("class.csv");
            r = new System.Random();
            sList = cdata.getStudentList();
        }

        public string getRandStudentName()
        {
            return cdata.getStudentData(r.Next(0, cdata.getListSize())).getName();
        }


        //名前から生徒データを逆引き
        public List<Student> SearchStudentName(string na)
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
        public List<Student> SearchStudentBirth(DateTime bt1, DateTime bt2)
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
        public Student SearchStudentNum(string n)
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