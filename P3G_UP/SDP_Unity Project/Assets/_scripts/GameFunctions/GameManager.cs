using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    /*
    public static void Save(UImanager uimanager)
    {
        BinaryFormatter bf = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerinfo.gg";
        FileStream file = new FileStream(path, FileMode.Create);
        //set data you want to save here
        playerData data = new playerData(uimanager);

        file.Close();
    }

    public static playerData Load()
    {
        string path = Application.persistentDataPath + "/playerinfo.gg";
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = new FileStream(path, FileMode.Open);

            playerData data = bf.Deserialize(file) as playerData;
            file.Close();

            return data;
        }
        else
        {
            Debug.LogError("save file not found in " + path);
            return null;
        }
    }
    */
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
}
