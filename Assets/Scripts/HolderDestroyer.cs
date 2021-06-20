using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HolderDestroyer : MonoBehaviour
{
    public float childCount;

    void start()
    {

    }

    void Update()
    {
        if (childCount < 0)
        {
            Destroy(gameObject);
        }
    }

    public void BulletDied( int ChildKilled)
        {
            childCount -= ChildKilled;
        }

    }

