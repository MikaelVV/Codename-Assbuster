using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speedwagon;
    public int enemyDamageGiven;
    public int bossDamageGiven;
    public GameObject DeathEffect;
    public Transform FxPoint;
    

    public Rigidbody2D rb;


    void Start()
    {

    }


    void Update()
    {
        rb.velocity = -transform.right * -speedwagon;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
            other.gameObject.GetComponent<EnemyHealth>().EnemyTakingDamage(enemyDamageGiven);
            Destroy(gameObject);
            
        }

        if (other.gameObject.tag == "Boss")
        {
            Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
            other.gameObject.GetComponent<Boss1>().BossTakingDamage(bossDamageGiven);
            other.gameObject.GetComponent<Boss1>().BossSetHealth();
            Destroy(gameObject);

        }

        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }

    }
}
