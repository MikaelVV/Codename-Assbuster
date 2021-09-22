using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[SerializeField]
public class ShopManager : MonoBehaviour
{
    public static ShopManager instance;
    public SavingSystem savingSystem;

    public bool[] itemsUnlocked = new bool[10] {false, false, false, false, false, false, false, false, false, false };
    public int[] itemPrices;

    public int shopTokens;
    public Text shopTokentext;


    private void Awake()
    {
        instance = this;
        itemsUnlocked = savingSystem.data.itemsUnlocked;
    }

    void Start()
    {

    }

    public void Update()
    {
        shopTokentext.text = savingSystem.data.shoptokens.ToString() + " $";
    }

}
