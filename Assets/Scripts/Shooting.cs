using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{

    public GameObject bullet;
    public Transform firepoint;
    public float time;
    public bool CantShoot;


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && CantShoot == false)
        {
            Shoot();
        }

        if (Input.GetKey(KeyCode.E))
        {
            Debug.Log("asd");
            CantShoot = false;

        }
    }

    public void Shoot()
    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);
        StartCoroutine("Cooldown");
    }

    IEnumerator Cooldown()

    {
        CantShoot = true;
        yield return new WaitForSeconds(time);
        CantShoot = false;
    }

}
