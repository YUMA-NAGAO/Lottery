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

        //コンストラクタ
        public CalcData()
        {
            cdata = new ClassData("class.csv");
            r = new System.Random();
        }

        public string getRandStudentName()
        {
            return cdata.getStudentData(r.Next(0, cdata.getListSize())).getName();
        }
    }

}