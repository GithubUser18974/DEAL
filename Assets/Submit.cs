using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using UnityEngine.Networking;

public class Submit : MonoBehaviour
{
    public int Code;
	public string Names;
	public string Area;
	public string SalesmanName;
	public int Shops;
	public string Date;
	public int CampgainType;
	public int No_campgain;
    //            Save(Code,Name,Area,SalesmanName,Shops,Date,CampgainType,No_campgain);


    public int filled = 0;
    FileInfo f;
  public  string path;
    void Start()
    {
        if(path==null||path==""||path==" ")
        {
            path = Application.persistentDataPath + " / data.txt";
            f = new FileInfo(Application.persistentDataPath + " / data.txt");
        }
        else
        {
            path = "D:/" + " / data.txt";
            f = new FileInfo("D:/" + " / data.txt");
        }
   
    }
    public void Save(int Code, string nName, string Area, string SalesmanName, int Shops, string Date, int CampgainType, int No_campgain)
    {
        StreamWriter w;
        if (!f.Exists)
        {
            w = f.CreateText();
        }
        else
        {
            w = new StreamWriter(path, true);
        }
        w.Write("| "+Code+" |" + "\t");
        w.Write("| " + nName + " |" + "\t");
        w.Write("| " + SalesmanName + " |" + "\t\t");
        w.Write("| " + Area + " |" + "\t\t");
        w.Write("| " + Date + " |" + "\t\t");
        w.Write("| " + Shops + " |" + "\t\t");
        w.Write("| " + CampgainType + " |" + "\t\t");
        w.Write("| " + No_campgain + " |" + "\t\t");
        w.WriteLine(" ");
        w.WriteLine("__________________________________________________________________________________________________________");
        w.Close();
    }
    public void submit()
    {
        AutoSubmit();


    }

    public void AutoSubmit()
    {


        Save(Code, Names, Area, SalesmanName, Shops, Date, CampgainType, No_campgain);


        Invoke("restart", 4);

    }
    private void HandleUploadResult(string result)
    {
        Debug.Log(result);
    }


    public void restart()
    {
        print("Goto");
        SceneManager.LoadScene(0);
    }


}
