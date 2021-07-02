using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtonInfo : MonoBehaviour
{
    public static ShopButtonInfo instance;

    public Button button;

    public int ItemID;
    public Text priceText;
    public Text Quantitytext;
    public GameObject ShopManager;

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {

    }

    void Update()
    {
        priceText.text = "$" + ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        Quantitytext.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();
    }

    public void Button()
    {
        if(ItemID == 1)
        {
            button.interactable = false;
        }else
        {
            button.interactable = true;
        }
    }
}
