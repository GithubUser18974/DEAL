using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Dealers dealers;
    #region PUBLIC UI VARIABLE
    public GameObject Game_1;
    public GameObject Game_2;
    public GameObject Game_3;
    public GameObject Game_4;
    public GameObject Game_5;
    public GameObject Game_6;
    public GameObject thanksPanel;
    public GameObject Game_4_Main;
    public GameObject Game_4_8;
    public GameObject Game_4_12;
    public GameObject Game_4_15;
    public GameObject textwrongCode;

    #endregion
    #region PUBLIC UI Text VARIABLE
    public Text textUserName;
    public Text textSalesName;
    public Text textDealValue;
    #endregion
    string currName = "";
    string currSalesName = "";
    string currArea = "";
    string currShops= "";
    string currStatus= "";
    int currCode = 0;
    int currSale = 0;
    int currCampgain = 8000;
    int currRatio = 8;
    bool isCodeCorrect = false;
    private void Start()
    {
        HideEverything();
        Start_Game_1();

    }
    public void Btn_CodeEnter(InputField inputField)
    {
        currCode = int.Parse(inputField.text);
        GetUserData(currCode);
        if (isCodeCorrect)
        {
            UpdateUI();
            Start_Game_3();
        }
        else
        {
            textwrongCode.SetActive(true);
        }
    }
    public void Btn_Start_Game_2()
    {
        Start_Game_2();
    }
    private static readonly Regex sWhitespace = new Regex(@"\s+");
    public static string ReplaceWhitespace(string input, string replacement)
    {
        return sWhitespace.Replace(input, replacement);
    }
    public void UpdateUI()
    {
        textUserName.text = currName;
        textSalesName.text = currSalesName;
    }
    public void GetUserData(int code)
    {
        foreach(MstItemEntity i in dealers.Main)
        {
            if (i.Code == code)
            {
                print("MATHCHED");
                currName = i.Name;
                currSalesName = i.SalesmanName;
                currArea = i.Area;
                currShops =""+ i.Shops;
                currStatus =""+ i.Status;
                isCodeCorrect = true;
                return;
            }
            
        }
        Debug.LogError("NOT FOUND");
        isCodeCorrect = false;
    }
    public void Start_Game_1()
    {
        Game_1.SetActive(true);
        Game_2.SetActive(false);
        Game_3.SetActive(false);
        Game_4.SetActive(false);
        Game_5.SetActive(false);
        Game_6.SetActive(false);
    }
    public void Start_Game_2()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(true);
        Game_3.SetActive(false);
        Game_4.SetActive(false);
        Game_5.SetActive(false);
        Game_6.SetActive(false);
    }
    public void Start_Game_3()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(false);
        Game_3.SetActive(true);
        Game_4.SetActive(false);
        Game_5.SetActive(false);
        Game_6.SetActive(false);
    }
    public void Start_Game_4()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(false);
        Game_3.SetActive(false);
        Game_4.SetActive(true);
        Game_5.SetActive(false);
        Game_6.SetActive(false);
    }
    [ContextMenu("8%")]
    public void StartGame_4_8()
    {
        Game_4_Main.SetActive(false);
        Game_4_15.SetActive(false);
        Game_4_12.SetActive(false);
        Game_4_8.SetActive(true);
    }
    [ContextMenu("12%")]
    public void StartGame_4_12()
    {
        Game_4_Main.SetActive(false);
        Game_4_15.SetActive(false);
        Game_4_12.SetActive(true);
        Game_4_8.SetActive(false);
    }
    [ContextMenu("15%")]
    public void StartGame_4_15()
    {
        Game_4_Main.SetActive(false);
        Game_4_15.SetActive(true);
        Game_4_12.SetActive(false);
        Game_4_8.SetActive(false);
    }
    public void Start_Game_5()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(false);
        Game_3.SetActive(false);
        Game_4.SetActive(false);
        Game_5.SetActive(true);
        Game_6.SetActive(false);
    }
    public void Start_Game_6()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(false);
        Game_3.SetActive(false);
        Game_4.SetActive(false);
        Game_5.SetActive(false);
        Game_6.SetActive(true);
    }
    public void HideEverything()
    {
        Game_1.SetActive(false);
        Game_2.SetActive(false);
        Game_3.SetActive(false);
        Game_4.SetActive(false);
        Game_5.SetActive(false);
        Game_6.SetActive(false);
    }
    public void Thanks()
    {
        thanksPanel.SetActive(true);

    }

    IEnumerator showThanks()
    {
        yield return new WaitForSeconds(3);
    }
    public GameObject[] selecItems;
    public void CountSelection(GameObject item)
    {
        SalesState(false);
        item.SetActive(true);
    }
    public void SetNumberOfItems(int sale)
    {
        currSale = sale;
        int val = currCampgain * currSale * currRatio / 100;
        SetDealValue(val);
    }
  public void SalesState(bool state)
    {
        currSale = -1;
        foreach (GameObject i in selecItems)
        {
            i.SetActive(state);
        }
    }
    public void ConfimOffer()
    {
        if (currSale > 0)
        {
            Start_Game_5();
        }
    }
    public void SetDealValue(int ratio)
    {
        textDealValue.text = "" + ratio;
    }
}
