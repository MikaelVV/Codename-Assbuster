using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeExplosion : MonoBehaviour
{
    public GameObject Spike;
    public Transform FxPoint1;
    public Transform FxPoint2;
    public Transform FxPoint3;
    public Transform FxPoint4;
    public Transform FxPoint5;
    public Transform FxPoint6;
    public Transform FxPoint7;
    public Transform FxPoint8;

    void Start()
    {
        Instantiate(Spike, FxPoint1.position, FxPoint1.rotation);
        Instantiate(Spike, FxPoint2.position, FxPoint2.rotation);
        Instantiate(Spike, FxPoint3.position, FxPoint3.rotation);
        Instantiate(Spike, FxPoint4.position, FxPoint4.rotation);
        Instantiate(Spike, FxPoint5.position, FxPoint5.rotation);
        Instantiate(Spike, FxPoint6.position, FxPoint6.rotation);
        Instantiate(Spike, FxPoint7.position, FxPoint7.rotation);
        Instantiate(Spike, FxPoint8.position, FxPoint8.rotation);
    }


}
