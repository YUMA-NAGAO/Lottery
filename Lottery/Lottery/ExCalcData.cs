using System;
using System.Collections.Generic;

namespace Lottery
{
    public class ExCalcData : CalcData
    {
        private ClassData cdata;
        private int eCheck = 0;     //エラー検出用 0:正常, -1:異常

        //コンストラクタ
        public ExCalcData()
        {
            cdata = new ClassData("class.csv", ref eCheck);
            sList = cdata.getStudentList();
        }

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

            if (sList.Count > 0)
            {
                return getRandStudentName();
            }
            else
            {
                return "誕生日の人がいませんでした。対象月をかえてください。";
            }

            
        }

    }
}