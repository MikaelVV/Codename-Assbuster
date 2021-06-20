using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class WeaponSwitching : MonoBehaviour
{
    public GameObject slot1;
    public GameObject slot2;
    public int selectedWeapon = 0;

    void Start()
    {
        slot1.gameObject.SetActive(true);
        slot2.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && selectedWeapon == 0)
        {   
            selectedWeapon = 1;
            slot2.gameObject.SetActive(true);
            slot1.gameObject.SetActive(false);

        }
        else if (Input.GetKeyDown(KeyCode.E) && selectedWeapon == 1)
        {   
            selectedWeapon = 0;
            slot1.gameObject.SetActive(true);
            slot2.gameObject.SetActive(false);

        }
    }

}
