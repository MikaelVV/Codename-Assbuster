using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speedwagon;
    

    void Start()
    {
        
    }

     void Update()
        {
            rb.velocity = -transform.right * speedwagon;
        }
    
}
