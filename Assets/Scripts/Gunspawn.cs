using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunspawn : MonoBehaviour
{
    public GameObject Gun;


    void Start()
    {
        Instantiate(Gun, transform.position, Quaternion.identity, transform);
    }

}
