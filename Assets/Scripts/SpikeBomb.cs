using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBomb : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedwagon;
    public int DamageGiven;
    public GameObject DeathEffect;
    public Transform FxPoint;
    public float time;

    void Start()
    {
        StartCoroutine("Timer");
    }

    void Update()
    {
        rb.velocity = transform.right * -speedwagon;
    }

        public IEnumerator Timer()

        {
            yield return new WaitForSeconds(time);
            Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
            Destroy(gameObject);
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
    }
}
