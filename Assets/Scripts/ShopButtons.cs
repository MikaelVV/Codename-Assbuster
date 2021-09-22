using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[SerializeField]
public class ShopButtons : MonoBehaviour
{
    public static ShopButtons instance;
    public SavingSystem savingSystem;
    public ShopManager shopManager;


    public Button button;

    public int currentItem;

    private void Awake()
    {
        instance = this;
        currentItem = savingSystem.data.currentItem;
    }
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
