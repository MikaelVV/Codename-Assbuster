using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpShooting : MonoBehaviour
{
    public Animator animator;
    public GameObject bullet;
    public Transform firepoint;
    bool CantShoot;
    public float time;

    void Start()
    {

    }


    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) == true && CantShoot == false)
        {
            animator.SetBool("Charging", true);

        }
        else
        {
            animator.SetBool("Charging", false);
        }

    }

    public void Shoot()

    {
        Instantiate(bullet, firepoint.position, firepoint.rotation);

    }

}





