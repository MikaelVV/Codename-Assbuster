using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrissCross : MonoBehaviour
{
    public float speedwagon;
    public int enemyDamageGiven;
    public int bossDamageGiven;
    public GameObject DeathEffect;
    public Transform FxPoint;
    public float time;

    public Rigidbody2D rb;

    void Start()
    {
        StartCoroutine("Timer");
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



        }

        if (other.gameObject.tag == "Boss")
        {
            Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
            other.gameObject.GetComponent<Boss1>().BossTakingDamage(bossDamageGiven);
            other.gameObject.GetComponent<Boss1>().BossSetHealth();


        }

        if (other.gameObject.tag == "Boundary")
        {
            Destroy(gameObject);
        }
    }
        public IEnumerator Timer()

        {
            yield return new WaitForSeconds(time);
            Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
            Destroy(gameObject);
        }
    }
