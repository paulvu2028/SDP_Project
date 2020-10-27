using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using Lowscope.Saving;

public class CharacterCustomisationOption : MonoBehaviour
{
    //this script only applies to customisation scene as it does not use a complete player prefab only the model for display
    private void Start()
    {
        
    }




    //submit dosent work *peter daos version9*
    /*
    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/PlayerModel.prefab");
        SceneManager.LoadScene(1);
    }*/
}
