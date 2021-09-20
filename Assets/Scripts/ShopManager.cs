using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;
    public SavingSystem savingSystem;

    public int[,] shopItems = new int[11,11];
    public int shopTokens;
    public Text ShopTokentext;


    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        shopItems = savingSystem.data.shopitems;
        ShopTokentext.text = savingSystem.data.shoptokens.ToString() + "$";

        //Kaupassa ostettavien esineiden IDt
        savingSystem.data.shopitems[1, 1] = 1;
        savingSystem.data.shopitems[1, 2] = 2;
        savingSystem.data.shopitems[1, 3] = 3;
        savingSystem.data.shopitems[1, 4] = 4;
        savingSystem.data.shopitems[1, 5] = 5;
        savingSystem.data.shopitems[1, 6] = 6;
        savingSystem.data.shopitems[1, 7] = 7;
        savingSystem.data.shopitems[1, 8] = 8;
        savingSystem.data.shopitems[1, 9] = 9;
        savingSystem.data.shopitems[1, 10] = 10;

        //Hinnat
        savingSystem.data.shopitems[2, 1] = 2;
        savingSystem.data.shopitems[2, 2] = 2;
        savingSystem.data.shopitems[2, 3] = 2;
        savingSystem.data.shopitems[2, 4] = 2;
        savingSystem.data.shopitems[2, 5] = 2;
        savingSystem.data.shopitems[2, 6] = 2;
        savingSystem.data.shopitems[2, 7] = 2;
        savingSystem.data.shopitems[2, 8] = 3;
        savingSystem.data.shopitems[2, 9] = 3;
        savingSystem.data.shopitems[2, 10] = 2;

        //Määrä
        savingSystem.data.shopitems[3, 1] = 0;
        savingSystem.data.shopitems[3, 2] = 0;
        savingSystem.data.shopitems[3, 3] = 0;
        savingSystem.data.shopitems[3, 4] = 0;
        savingSystem.data.shopitems[3, 5] = 0;
        savingSystem.data.shopitems[3, 6] = 0;
        savingSystem.data.shopitems[3, 7] = 0;
        savingSystem.data.shopitems[3, 8] = 0;
        savingSystem.data.shopitems[3, 9] = 0;
        savingSystem.data.shopitems[3, 10] = 0;

    }

    public void BuyItems()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;


        if (savingSystem.data.shoptokens >= savingSystem.data.shopitems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            savingSystem.data.shoptokens -= savingSystem.data.shopitems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID];
            savingSystem.data.shopitems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID]++;
            ShopTokentext.text = savingSystem.data.shoptokens.ToString() + "$";
            ButtonRef.GetComponent<ShopButtonInfo>().Quantitytext.text = savingSystem.data.shopitems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID].ToString();

            PlayerPrefs.SetInt("shopTokens", savingSystem.data.shoptokens);
        }

        if (savingSystem.data.shoptokens < savingSystem.data.shopitems[2, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            //ButtonRef.GetComponent<ShopButtonInfo>().button.interactable = false;
            Debug.Log("Ei ole rahaa ");
            savingSystem.Save();
        }

        //Tässä switch casessa kaupassa ostettujen aseiden / poweruppien pitäisi tallentua, niinkuin tallentuukin, mutta vain pelin päälläolon ajaksi. En ole vielä saanut tätä toimimaan täysin.
        switch (savingSystem.data.shopitems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID])
        {
            case 1:
                Debug.Log("Tuote osettu!");
                savingSystem.Save();
                //PlayerPrefs.SetInt("shopItems", shopItems[3, ButtonRef.GetComponent<ShopButtonInfo>().ItemID] = 1);
                ButtonRef.GetComponent<ShopButtonInfo>().button.interactable = false;
                break;
            default:
                Debug.Log("default");
                break;
        }
    }

   /* public void SaveShop()
    {
        SavingSystem.SaveShop(this);
    }

    public void LoadShop()
    {
        ShopData data = SavingSystem.LoadShop();

        shopItems = data.shopitems;
        ShopButtonInfo.instance.Button();
    } */
}
