using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
    public AudioClip CollectedCoin;
 
     void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        CoinPoints.instance.AddCoins();
        Destroy(gameObject);
        controller.PlaySound(CollectedCoin);
    }
    
}

