using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    public AudioClip collectedCoin;

     void OnTriggerEnter2D(Collider2D other)
    {
       
        Destroy(gameObject);

    }
}

