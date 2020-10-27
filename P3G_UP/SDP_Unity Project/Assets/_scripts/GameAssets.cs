using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _character;

    public static GameAssets character
    {
        get
        {
            if(_character == null) _character = (Instantiate(Resources.Load("GameAssets")) as GameObject).GetComponent<GameAssets>(); 
            return _character;
        }
    }

    public Sprite CharacterMaleJacket;
    public Sprite CharacterBusinessManSuit;
    public Sprite CharacterBusinessManShirt;
    public Sprite CharacterBusinessWoman;
    public Sprite CharacterFemaleCoat;
    public Sprite CharacterFemaleJacket;
    public Sprite CharacterFemalePolice;
    public Sprite CharacterMaleHoodie;
    public Sprite CharacterMalePolice;
}
