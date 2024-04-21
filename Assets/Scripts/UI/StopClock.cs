using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopClock : MonoBehaviour
{
    public void OnTriggerEnter2D(){
        Destroy(gameObject);
    }
     }

