﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform firepoint;
    public float time;
    bool CantShoot;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && CantShoot == false)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
        StartCoroutine("Cooldown");
    }

    public IEnumerator Cooldown()

    {
        CantShoot = true;
        yield return new WaitForSeconds(time);
        CantShoot = false;
    }

}
