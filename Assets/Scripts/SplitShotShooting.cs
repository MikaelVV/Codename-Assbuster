using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitShotShooting : MonoBehaviour
{
    public GameObject bullet;
    public float time;
    bool CantShoot;
    public Transform firepoint1;
    public Transform firepoint2;
    public Transform firepoint3;
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.Space) == true && CantShoot == false)
        {
            Shoot();

        }
    }

    public void Shoot()
    {
        Instantiate(bullet, firepoint1.position, firepoint1.rotation);
        Instantiate(bullet, firepoint2.position, firepoint2.rotation);
        Instantiate(bullet, firepoint3.position, firepoint3.rotation);
        StartCoroutine("Cooldown");
    }

    public IEnumerator Cooldown()

    {
        CantShoot = true;
        yield return new WaitForSeconds(time);
        CantShoot = false;
    }

}
