using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gunspawn : MonoBehaviour
{
    public GameObject Gun;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Gun, transform.position, Quaternion.identity, transform);
    }

}
