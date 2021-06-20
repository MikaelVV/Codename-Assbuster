using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusEffectManager : MonoBehaviour
{
    public int enemyDamageGiven;
    private EnemyHealth healthScript;

    public List<int> toxinTickTimers = new List<int>();

    void Start()
    {
        healthScript = GetComponent<EnemyHealth>();
    }


    public void ApplyToxin(int ticks)
    {
        if (toxinTickTimers.Count <= 0)
        {
            toxinTickTimers.Add(ticks);
            StartCoroutine(Toxin());
        }
        else
        {
            toxinTickTimers.Add(ticks);
        }

    }

    IEnumerator Toxin()
    {
        while(toxinTickTimers.Count > 0)
        {
            for(int i = 0; i < toxinTickTimers.Count; i++)
            {
                toxinTickTimers[i]--;
            }
            gameObject.GetComponent<EnemyHealth>().EnemyTakingDamage(enemyDamageGiven);
            toxinTickTimers.RemoveAll(number => number == 0);
            yield return new WaitForSeconds(0.75f);
        }
    }

}
