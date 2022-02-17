using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{

	public int Code;
	public string Name;
	public string Area;
	public string SalesmanName;
	public int Shops;
	public string Date;
	public int CampgainType;
	public int No_campgain;
	public PlayerData (int code, string name , string area , string salesman,int shops,string date,int campgainType,int No_campgain)
    {
		Code = code;
		Name = name;
		SalesmanName = salesman;
		CampgainType = campgainType;
		this.No_campgain = No_campgain;
		Date = date;
		Shops = shops;
		Area = area;

    }

}
