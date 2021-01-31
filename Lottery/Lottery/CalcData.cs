using System;
using System.IO;
using System.Collections.Generic;

public class CalcData
{
	int rvalue;
	//コンストラクタ
	public CalcData()
	{
		ClassData cdata = new ClassData();
		Random r = new System.Random();
	}

	public getRandStudentName()
	{
		return cdata.getStudentData(r.Next(0, cdata.getListSize())).getName();
	}
}
