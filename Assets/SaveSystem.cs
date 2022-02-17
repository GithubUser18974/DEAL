using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void savePlayer(int code, string name, string area, string salesman, int shops, string date, int campgainType, int No_campgain)
    {
        //Creating Binary formatter;
        BinaryFormatter formatter = new BinaryFormatter();

        //The Application.presentationDataPath returning an non obvious 
        string path  = Application.persistentDataPath + "/test.txt";

        
        FileStream stream = new FileStream(path, FileMode.Create);
        PlayerData data = new PlayerData(code, name, area, salesman, shops, date, campgainType, No_campgain);
        formatter.Serialize(stream, data);
        Debug.Log("DONE");
        stream.Close();
        Debug.Log(path);

    }

    public static PlayerData loadPlayer()
    {
        string path = Application.persistentDataPath + "/test.txt";
        if (File.Exists(path))
        {
            //Creating Binary formatter;
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            PlayerData data = (PlayerData)formatter.Deserialize(stream);
            stream.Close();

            return data;
        }
        else
        {
            Debug.LogError("Save file not found in: " + path);
            return null;
        }
    }
}