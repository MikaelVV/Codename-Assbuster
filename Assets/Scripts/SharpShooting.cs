using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharpShooting : MonoBehaviour
{
    public Animator animator;
    public GameObject bullet;
    public Transform firepoint;
    private bool CantShoot = false;
    public float time;

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





