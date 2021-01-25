using System;
using System.IO;
using System.Collections.Generic;

public class test{
    public static void Main(String[] args){
        ClassData data = new ClassData("class.csv");
        Console.WriteLine(data.getStudentData(1).getNum());
        //Console.WriteLine(data.getStudentName(1));
    }
}

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
            Student tmp = new Student(data[0], data[1], Int32.Parse(data[2]));
            StudentList.Add(tmp);
        }
        file.Close();        
    }

    //生徒のデータを返す
    public Student getStudentData(int n){
        return StudentList[n];
    }

    //Listのデータ数を返す
    public int getListSize(){
        return StudentList.Count;
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
    private int birthday;

    public Student(String n,String na,int birth){
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

    public int getBirth(){
        return birthday;
    }

}

