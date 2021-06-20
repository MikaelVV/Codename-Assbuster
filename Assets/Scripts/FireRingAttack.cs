using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireRingAttack : MonoBehaviour
{

    public int enemyDamageGiven;
    public int bossDamageGiven;
    public float time;


    void Start()
    {

    }

    void Update()
    {
        Destroy(gameObject, time);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            other.gameObject.GetComponent<EnemyHealth>().EnemyTakingDamage(enemyDamageGiven);
        }

        if (other.gameObject.tag == "Boss")
        {
            other.gameObject.GetComponent<Boss1>().BossTakingDamage(bossDamageGiven);
            other.gameObject.GetComponent<Boss1>().BossSetHealth();
        }
    }
}
