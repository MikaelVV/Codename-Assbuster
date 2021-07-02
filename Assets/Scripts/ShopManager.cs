using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;

    public int[,] shopItems = new int[11,11];
    public float shopTokens;
    public Text ShopTokentext;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        shopTokens = PlayerPrefs.GetFloat("shopTokens", 100);
        ShopTokentext.text = shopTokens.ToString() + "$";

        //Kaupassa ostettavien esineiden IDt
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        shopItems[1, 6] = 6;
        shopItems[1, 7] = 7;
        shopItems[1, 8] = 8;
        shopItems[1, 9] = 9;
        shopItems[1, 10] = 10;

        //Hinnat
        shopItems[2, 1] = 2;
        shopItems[2, 2] = 2;
        shopItems[2, 3] = 2;
        shopItems[2, 4] = 2;
        shopItems[2, 5] = 2;
        shopItems[2, 6] = 2;
        shopItems[2, 7] = 2;
        shopItems[2, 8] = 3;
        shopItems[2, 9] = 3;
        shopItems[2, 10] = 2;

        //Määrä
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;
        shopItems[3, 5] = 0;
        shopItems[3, 6] = 0;
        shopItems[3, 7] = 0;
        shopItems[3, 8] = 0;
        shopItems[3, 9] = 0;
        shopItems[3, 10] = 0;

    }

    public void BuyItems()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;


        if (shopTokens >= shopItems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            shopTokens -= shopItems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID];
            shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID]++;
            ShopTokentext.text = shopTokens.ToString() + "$";
            ButtonRef.GetComponent<ShopButtonInfo>().Quantitytext.text = shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID].ToString();

            PlayerPrefs.SetFloat("shopTokens", shopTokens);
        }

        if (shopTokens < shopItems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            //ButtonRef.GetComponent<ShopButtonInfo>().button.interactable = false;
            Debug.Log("Ei ole rahaa ");
        }

        //Tässä switch casessa kaupassa ostettujen aseiden / poweruppien pitäisi tallentua, niinkuin tallentuukin, mutta vain pelin päälläolon ajaksi. En ole vielä saanut tätä toimimaan täysin.
        switch (shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            case 1:
                Debug.Log("Tuote osettu!");
                //PlayerPrefs.SetInt("shopItems", shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID] = 1);
                ButtonRef.GetComponent<ShopButtonInfo>().button.interactable = false;
                //PlayerPrefs.Save();
                break;
            default:
                Debug.Log("Tuotteita ei ole vielä ostettu");
                PlayerPrefs.GetInt("shopitems", shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID] = 0);
                break;
        }
    }

    public void SaveShop()
    {
        SavingSystem.SaveShop(this);
    }

    public void LoadShop()
    {
        ShopData data = SavingSystem.LoadShop();

        shopItems = data.shopitems;
        ShopButtonInfo.instance.Button();
    } 
}
