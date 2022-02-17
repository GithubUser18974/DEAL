using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class MstItemEntity
{
	public int Code;
	public string Name;
	public string Area;
	public string SalesmanName;
	public int Shops;
	public string Date;
	public string Status;
	public MstItemCategory category;

}

public enum MstItemCategory
{
	Red,
	Green,
	Blue,
}