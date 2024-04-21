using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    public AudioClip CollectedCoin;
    AudioSource audioSource;
    void Start(){
        audioSource = GetComponent<AudioSource>();
    }
    
     void OnTriggerEnter2D(Collider2D other)
    {
        CoinPoints.instance.AddCoins();
        Destroy(gameObject);
        audioSource.PlayOneShot(CollectedCoin);
        
    }
}

