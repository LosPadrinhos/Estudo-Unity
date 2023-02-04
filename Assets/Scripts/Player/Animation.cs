using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{

    Animator animator;
    
    // Sistema de animacao do char
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool isWalking = animator.GetBool("isWalking");
        bool pressionado = Input.GetKey("w") || Input.GetKey("s");
       

        if (pressionado)
        {
            animator.SetBool("isWalking", true);
        }
        if (!pressionado)
        {
            animator.SetBool("isWalking", false);
        }

    }
}
