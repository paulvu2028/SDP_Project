using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShop : MonoBehaviour
{
    public GameObject SelectionImg;
    public UImanager uImanager;

    public int currentSelectedItem;
    public int currentItemCost;

    [SerializeField] public Text owned1, owned2, owned3;

    public void UpdateShopSelection(int yPosition)
    {
        SelectionImg.GetComponent<Image>().rectTransform.anchoredPosition = new Vector2(SelectionImg.GetComponent<Image>().rectTransform.anchoredPosition.x, yPosition);
    }

    private void Awake()
    {

    }

    private void Start()
    {

    }

    private void Update()
    {
        if (GameManager.control.skin1 == true)
        {
            owned1.text = "owned";
        }
        if (GameManager.control.skin2 == true)
        {
            owned2.text = "owned";
        }
        if (GameManager.control.skin3 == true)
        {
            owned3.text = "owned";
        }
    }

    public void SelectItem(int Item)
    {
        SelectionImg.SetActive(true);
        switch (Item)
        {
            //charaters 0 - 10
            case 0:
                UpdateShopSelection(260);
                currentSelectedItem = 0;
                currentItemCost = 10;
                break;
            case 1:
                UpdateShopSelection(218);
                currentSelectedItem = 1;
                currentItemCost = 15;
                break;
            case 2:
                UpdateShopSelection(174);
                currentSelectedItem = 2;
                currentItemCost = 15;
                break;

        }
    }

    public void BuyItem()
    {
        //if playerscoins is greater than or equal to cost of select item
        if (uImanager.coinCount >= currentItemCost)
        {
            if (currentSelectedItem == 0)
            {
                owned1.text = "owned";
                GameManager.control.skin1 = true;
            }
            if (currentSelectedItem == 1)
            {
                owned2.text = "owned";
                GameManager.control.skin2 = true;
            }
            if (currentSelectedItem == 2)
            {
                owned3.text = "owned";
                GameManager.control.skin3 = true;
            }
            uImanager.UpdateCoins(-currentItemCost);
        }

    }
}
