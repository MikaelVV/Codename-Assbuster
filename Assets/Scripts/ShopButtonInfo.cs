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
        PlayerPrefs.GetInt("shopitems", ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] = 0);
    }

    void Update()
    {
        priceText.text = "$" + ShopManager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        Quantitytext.text = ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();
    }

    //Tässä voidissa kaupassa ostettujen aseiden / poweruppien pitäisi tallentua, niinkuin tallentuukin, mutta vain pelin päälläolon ajaksi. En ole vielä saanut tätä toimimaan täysin.
    public void SavingPurchase()
    {
        switch (ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID])
        {
            case 1:
                Debug.Log("Tuote osettu!");
                PlayerPrefs.SetInt("shopItems", ShopManager.GetComponent<ShopManager>().shopItems[3, ItemID] = 1);
                button.interactable = false;
                PlayerPrefs.Save();
                break;
            default:
                Debug.Log("Tuotteita ei ole vielä ostettu");
                break;
        }
    }

}
