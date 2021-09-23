using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponConfirmer : MonoBehaviour
{
    public SavingSystem savingSystem;

    public Button button;

    public GameObject selectedGun;

    public int currentWeapon;
    public bool chooseGun;


    void Start()
    {
        selectedGun = savingSystem.data.selectedGun;
        currentWeapon = savingSystem.data.currentItem;
    }


    void Update()
    {
        if(savingSystem.data.itemsUnlocked[currentWeapon] == true)
        {
            button.interactable = true;
 
        }
        else if(savingSystem.data.itemsUnlocked[currentWeapon] == false)
        {
            button.interactable = false;
        }
    }

    public void OnClick()
    {
        //selectedGun = [currentWeapon];
    }
}
