using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CharacterCustomisationOption : MonoBehaviour
{
    public GameObject character;

    public void Submit()
    {
        PrefabUtility.SaveAsPrefabAsset(character, "Assets/PlayerModel.prefab");
        SceneManager.LoadScene(1);
    }
}
