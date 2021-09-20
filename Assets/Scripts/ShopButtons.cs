using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopButtons : MonoBehaviour
{
    public SavingSystem savingSystem;
    public ShopManager shopManager;


    public Button button;

    public int currentItem;

    void Start()
    {
        
    }


    void Update()
    {
        if(button.gameObject.activeInHierarchy)
        {
            button.interactable = (savingSystem.data.shoptokens >= shopManager.itemPrices[currentItem]);
        }
    }

    public void BuyItems()
    {
        savingSystem.data.shoptokens -= shopManager.itemPrices[currentItem];
        savingSystem.data.itemsUnlocked[currentItem] = true;
        savingSystem.Save();
        UIupdate();
    }

    public void UIupdate()
    {
        if (savingSystem.data.itemsUnlocked[currentItem])
        {
            button.interactable = true;
        }
        else
        {
            button.interactable = false;

        }
    }
}
