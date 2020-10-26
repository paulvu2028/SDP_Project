using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIShop : MonoBehaviour
{
    public GameObject SelectionImg;


    public int _currentSelectedItem;
    public int _currentItemCost;

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

    public void SelectItem(int Item)
    {
        SelectionImg.SetActive(true);
        switch (Item)
        {
            //charaters 0 - 10
            case 0:
                UpdateShopSelection(260);
                _currentSelectedItem = 0;
                _currentItemCost = 10;
                break;
            case 1:
                UpdateShopSelection(218);
                _currentSelectedItem = 1;
                _currentItemCost = 15;
                break;
            case 2:
                UpdateShopSelection(174);
                _currentSelectedItem = 1;
                _currentItemCost = 15;
                break;

        }
    }

}
