using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public int DamageGiven;
    public Rigidbody2D rb;
    public float speedwagon;
    public GameObject DeathEffect;
    public Transform FxPoint;

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
                Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
                Destroy(gameObject);

        }
            if (other.gameObject.tag == "Boundary")
            {
                Destroy(gameObject);
            }

        }
    }

