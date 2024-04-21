using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goblin : MonoBehaviour
{
    public Transform[] patrolPoints;
    public int targetPoint;
    public float speed;
    public GameObject coin;

    void Start()
    {
        targetPoint = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == patrolPoints[targetPoint].position){
            increaseTargetInt();
        }

        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[targetPoint].position, speed * Time.deltaTime);

    }

    public void OnTriggerEnter2D(){
        if(coin.activeInHierarchy == false){
            coin.SetActive(true);

        
        }
        else{
            coin.SetActive(false);
        }
            
    }
    void increaseTargetInt(){
        targetPoint++;
    }

}

