using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GivingDamage : MonoBehaviour
{
    public int DamageGiven;
    public int enemyDamageGiven;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.name == "Pelaaja")
        {
            col.gameObject.GetComponent<PlayerController>().TakingDamage(DamageGiven);
            col.gameObject.GetComponent<PlayerController>().SetHealth();
        }
    }
}
