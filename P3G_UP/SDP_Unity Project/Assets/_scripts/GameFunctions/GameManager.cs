using Lowscope.Saving;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour, ISaveable
{
    //this class controls global variables for saving and carrying over to seperate scenes
    public static GameManager control;

    bool isloaded;
    
    //skins bool
    public bool skin1, skin2, skin3;



    [System.Serializable]
    public struct SaveData
    {
        public int savedModel;
        public bool skin1, skin2, skin3;

    }

    //this int keeps track of model player has saved and should be using
    public int characterModel = 0;

    public void OnLoad(string data)
    {
        SaveData saveData = JsonUtility.FromJson<SaveData>(data);
        characterModel = saveData.savedModel;
        isloaded = true;

        skin1 = saveData.skin1;
        skin2 = saveData.skin2;
        skin3 = saveData.skin3;

    }

    public string OnSave()
    {
        return JsonUtility.ToJson(new SaveData() { savedModel = this.characterModel, skin1 = this.skin1, skin2 = this.skin2, skin3 = this.skin3 });
    }

    public bool OnSaveCondition()
    {
        return true;
    }

    private void Awake()
    {
        if (control == null)
        {
            DontDestroyOnLoad(gameObject);
            control = this;
        }
        else if (control != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
