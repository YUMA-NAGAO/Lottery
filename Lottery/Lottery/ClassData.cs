using System;
using System.IO;
using System.Collections.Generic;

//public class test{
//    public static void Main(String[] args){
//        ClassData data = new ClassData("class.csv");
//        Console.WriteLine(data.getStudentData(1).getBirth());
//        //Console.WriteLine(data.getStudentName(1));
//    }
//}

public class ClassData{
    private List<Student> StudentList;

    //コンストラクタ
    public ClassData(string filename){
        StreamReader file = new StreamReader(filename);
        StudentList = new List<Student>();

        char[] separator = new char[] {',',' ','　'};
        while(!file.EndOfStream){
            String line = file.ReadLine();
            String[] data = line.Split(separator,StringSplitOptions.RemoveEmptyEntries);
            Student tmp = new Student(data[0], data[1], DateTime.ParseExact(data[2],"MM/dd",null));
            StudentList.Add(tmp);
        }
        file.Close();        
    }

    //指定位置の生徒のデータを返す
    public Student getStudentData(int n){
        return StudentList[n];
    }

    //Listのデータ数を返す
    public int getListSize(){
        return StudentList.Count;
    }

    //名前から生徒データを逆引き
    public List<Student> SearchStudentName(string na){
        List<Student> temp = new List<Student>();
        foreach(Student s in StudentList){
            if(string.Compare(na, s.getName()) == 0){
                temp.Add(s);
            }
        }
        return temp;
    }

    //誕生日から生徒データを逆引き
    public List<Student> SearchStudentBirth(DateTime bt1, DateTime bt2){
        List<Student> temp = new List<Student>();
        foreach(Student s in StudentList){
            if(bt1.Date <= s.getBirth().Date && s.getBirth().Date <= bt2.Date ){
                temp.Add(s);
            }
        }
        return temp;
    }

    //出席番号から生徒データを逆引き
    public Student SearchStudentNum(string n){
        foreach (Student s in StudentList)
        {
            if(string.Compare(n, s.getNum()) == 0){
                return s;
            }
        }
        return null;
    }

    /*
    //生徒の出席番号を返す
    public string getStudentNum(int n){
        return StudentList[n].getNum();
    }

    //生徒の名前を返す
    public string getStudentName(int n){
        return StudentList[n].getName();
    }

    //生徒の誕生日を返す
    public int getStudentBirth(int n){
        return StudentList[n].getBirth();
    }
    */
}

public class Student{
    private string number,name;
    private DateTime birthday;

    public Student(String n,String na,DateTime birth){
        number = n;
        name = na;
        birthday = birth;
    }


    public string getNum(){
        return number;
    }

    public string getName(){
        return name;
    }

    public DateTime getBirth(){
        return birthday;
    }

}

