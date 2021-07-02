using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ShopData 
{
    public int[,] shopitems;

    public ShopData(ShopManager shopmanager)
    {
        shopitems = shopmanager.shopItems;
    }

}
