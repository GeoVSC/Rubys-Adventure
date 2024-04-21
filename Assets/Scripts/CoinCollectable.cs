using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollectable : MonoBehaviour
{
<<<<<<< Updated upstream
    public AudioClip collectedCoin;

     void OnTriggerEnter2D(Collider2D other)
    {
       
        Destroy(gameObject);

=======
    public AudioClip CollectedCoin;
 
     void OnTriggerEnter2D(Collider2D other)
    {
        RubyController controller = other.GetComponent<RubyController>();

        CoinPoints.instance.AddCoins();
        Destroy(gameObject);
        controller.PlaySound(CollectedCoin);
>>>>>>> Stashed changes
    }
    
}

