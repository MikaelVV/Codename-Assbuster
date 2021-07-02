using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using UnityEngine.SceneManagement;

public static class SavingSystem
{

    public static void SavePlayer (PlayerController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerData data = new PlayerData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveShop (ShopManager shopmanager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/shopdata.fun";
        FileStream stream = new FileStream(path, FileMode.Create);

        ShopData data = new ShopData(shopmanager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static ShopData LoadShop()
    {
        string path = Application.persistentDataPath + "/shopdata.fun";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            ShopData data = formatter.Deserialize(stream) as ShopData;
            stream.Close();

            return data;

        }else
        {
            Debug.LogError("Savefile not found");
            return null;
        }
    }

    public static PlayerData LoadPlayer()
    {
        string path = Application.persistentDataPath + "/player.save";
        if(File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerData data = formatter.Deserialize(stream) as PlayerData;
            stream.Close();

            return data;

        } else
        {
            Debug.LogError("Tallennusta ei löytynyt kohteesta" + path);
            return null;
        }
    }

}
