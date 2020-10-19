using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character
{
    public enum CharacterType
    {
        CharacterMaleJacket,
        CharacterBusinessManSuit,
        CharacterBusinessManShirt,
        CharacterBusinessWoman,
        CharacterFemaleCoat,
        CharacterFemaleJacket,
        CharacterFemalePolice,
        CharacterMaleHoodie,
        CharacterMalePolice
}

    public static int GetCost(CharacterType characterType)
    {
        switch(characterType)
        {
            default:
            case CharacterType.CharacterMaleJacket:
                return 180;
            case CharacterType.CharacterBusinessManSuit:
                return 200;
            case CharacterType.CharacterBusinessManShirt:
                return 180;
            case CharacterType.CharacterBusinessWoman:
                return 190;
            case CharacterType.CharacterFemaleCoat:
                return 150;
            case CharacterType.CharacterFemaleJacket:
                return 200;
            case CharacterType.CharacterFemalePolice:
                return 140;
            case CharacterType.CharacterMaleHoodie:
                return 120;
            case CharacterType.CharacterMalePolice:
                return 160;
        }
    }

    public static Sprite GetSprite(CharacterType characterType)
    {
        switch(characterType)
        {
            default:
            case CharacterType.CharacterMaleJacket:
                return GameAssets.character.CharacterMaleJacket;
            case CharacterType.CharacterBusinessManSuit:
                return GameAssets.character.CharacterBusinessManSuit;
            case CharacterType.CharacterBusinessWoman:
                return GameAssets.character.CharacterBusinessWoman;
            case CharacterType.CharacterFemaleCoat:
                return GameAssets.character.CharacterFemaleCoat;
            case CharacterType.CharacterFemaleJacket:
                return GameAssets.character.CharacterFemaleJacket;
            case CharacterType.CharacterFemalePolice:
                return GameAssets.character.CharacterFemalePolice;
            case CharacterType.CharacterMaleHoodie:
                return GameAssets.character.CharacterMaleHoodie;
            case CharacterType.CharacterBusinessManShirt:
                return GameAssets.character.CharacterBusinessManShirt;
            case CharacterType.CharacterMalePolice:
                return GameAssets.character.CharacterMalePolice;
        }
    }
}
