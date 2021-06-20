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

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.E) && selectedWeapon == 0)
        {
            slot2.gameObject.SetActive(true);
            slot1.gameObject.SetActive(false);
            selectedWeapon++;
        }
        else if (Input.GetKey(KeyCode.Q) && selectedWeapon == 1)
        {
            slot1.gameObject.SetActive(true);
            slot2.gameObject.SetActive(false);
            selectedWeapon--;
        }
    }

}
