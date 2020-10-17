using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public enum ItemType
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

    public static int GetCost(ItemType itemType)
    {
        switch(itemType)
        {
            default:
            case ItemType.CharacterMaleJacket:
                return 180;
            case ItemType.CharacterBusinessManSuit:
                return 200;
            case ItemType.CharacterBusinessManShirt:
                return 180;
            case ItemType.CharacterBusinessWoman:
                return 190;
            case ItemType.CharacterFemaleCoat:
                return 150;
            case ItemType.CharacterFemaleJacket:
                return 200;
            case ItemType.CharacterFemalePolice:
                return 140;
            case ItemType.CharacterMaleHoodie:
                return 120;
            case ItemType.CharacterMalePolice:
                return 160;
        }
    }

    public static Sprite GetSprite(ItemType itemType)
    {
        switch(itemType)
        {
            default:
            case ItemType.CharacterMaleJacket:
                return GameAssets.character.CharacterMaleJacket;
            case ItemType.CharacterBusinessManSuit:
                return GameAssets.character.CharacterBusinessManSuit;
            case ItemType.CharacterBusinessWoman:
                return GameAssets.character.CharacterBusinessWoman;
            case ItemType.CharacterFemaleCoat:
                return GameAssets.character.CharacterFemaleCoat;
            case ItemType.CharacterFemaleJacket:
                return GameAssets.character.CharacterFemaleJacket;
            case ItemType.CharacterFemalePolice:
                return GameAssets.character.CharacterFemalePolice;
            case ItemType.CharacterMaleHoodie:
                return GameAssets.character.CharacterMaleHoodie;
            case ItemType.CharacterBusinessManShirt:
                return GameAssets.character.CharacterBusinessManShirt;
            case ItemType.CharacterMalePolice:
                return GameAssets.character.CharacterMalePolice;
        }
    }
}
