using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;

    private void Awake()
    {
        container = transform.Find("Container");
        shopItemTemplate = container.Find("ShopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterMaleJacket), "Male Jacket", Character.GetCost(Character.CharacterType.CharacterMaleJacket), 0);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterBusinessManSuit), "Business Suit", Character.GetCost(Character.CharacterType.CharacterBusinessManSuit), 1);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterBusinessManShirt), "Business Shirt", Character.GetCost(Character.CharacterType.CharacterBusinessManShirt), 2);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterBusinessWoman), "Business Woman", Character.GetCost(Character.CharacterType.CharacterBusinessWoman), 3);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterFemaleCoat), "Female Coat", Character.GetCost(Character.CharacterType.CharacterFemaleCoat), 4);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterFemaleJacket), "Female Jacket", Character.GetCost(Character.CharacterType.CharacterFemaleJacket), 5);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterFemalePolice), "Female Police", Character.GetCost(Character.CharacterType.CharacterFemalePolice), 6);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterMaleHoodie), "Male Hoodie", Character.GetCost(Character.CharacterType.CharacterMaleHoodie), 7);
        CreateButton(Character.GetSprite(Character.CharacterType.CharacterMalePolice), "Male Police", Character.GetCost(Character.CharacterType.CharacterMalePolice), 8);
    }

    private void CreateButton(Sprite imageSprite, string name, int cost, int position)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 50f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * position);

        shopItemTransform.Find("NameText").GetComponent<TextMeshProUGUI>().SetText(name);
        shopItemTransform.Find("CostText").GetComponent<TextMeshProUGUI>().SetText(cost.ToString());
        shopItemTransform.Find("Image").GetComponent<Image>().sprite = imageSprite;
    }
}
