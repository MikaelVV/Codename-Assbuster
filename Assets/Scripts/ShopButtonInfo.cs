using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonInfo : MonoBehaviour
{
    public Button button;

    public int ItemID;
    public Text priceText;
    public Text Quantitytext;
    public GameObject ShopManager;

    void Start()
    {
       ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] = PlayerPrefs.GetInt("shopitems", ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] = 0);
    }

    void Update()
    {
        priceText.text = "$" + ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        Quantitytext.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();

        if(ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] == 1)
        {
            PlayerPrefs.SetInt("shopitems", ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] = 1);
            ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID]++;
            button.interactable = false;
        }
    }
}
