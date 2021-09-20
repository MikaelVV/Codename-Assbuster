using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonInfo : MonoBehaviour
{
    public static ShopButtonInfo instance;
    public SavingSystem savingSystem;

    public Button button;

    public int ItemID;
    public int price = 2;
    public Text priceText;
    public Text Quantitytext;
    public GameObject ShopManager;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        priceText.text = savingSystem.data.price.ToString();
        Quantitytext.text = savingSystem.data.quantity.ToString();
    }

    void Update()
    {
        priceText.text = "$" + savingSystem.data.shopitems[2, ItemID].ToString();
        Quantitytext.text = savingSystem.data.shopitems[3, ItemID].ToString();
    }

    public void Button()
    {
        if(savingSystem.data.shopitems[3, ItemID] == 1)
        {
            button.interactable = false;
        }
        else
        {
            button.interactable = true;
        }
    }
}
