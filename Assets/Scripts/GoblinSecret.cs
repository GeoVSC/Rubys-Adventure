using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoblinSecret : MonoBehaviour
{

    public float runSpeed;
    public float activeRadius;

    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
