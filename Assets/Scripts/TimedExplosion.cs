using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedExplosion : MonoBehaviour
{
    public GameObject DeathEffect;
    public float time;
    public Transform FxPoint;

    //Lisää kohta jossa se spawnaa ne sirpaleet ja räjähys efektin
    void Start()
    {
        StartCoroutine("Timer");
    }

    public IEnumerator Timer()

    {
        yield return new WaitForSeconds(time);
        Instantiate(DeathEffect, FxPoint.position, FxPoint.rotation);
        Destroy(gameObject);
    }

}
