using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibleBullet : MonoBehaviour
{
    public int DamageGiven;
    public Rigidbody2D rb;
    public float speedwagon;


    void Start()
    {

    }

    void Update()
    {
        rb.velocity = transform.right * -speedwagon;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().TakingDamage(DamageGiven);
            other.gameObject.GetComponent<PlayerController>().SetHealth();

        }
        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

    }
}
