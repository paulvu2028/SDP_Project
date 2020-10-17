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
        CreateItemButton(Item.GetSprite(Item.ItemType.CharacterMaleJacket), "Male Jacket", Item.GetCost(Item.ItemType.CharacterMaleJacket), 0);
        CreateItemButton(Item.GetSprite(Item.ItemType.CharacterBusinessManSuit), "Business Suit", Item.GetCost(Item.ItemType.CharacterBusinessManSuit), 1);
    }

    private void CreateItemButton(Sprite imageSprite, string name, int cost, int position)
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
