using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    public PlayerMovement pMov;
    public Animator animator;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", Math.Abs(pMov.movement.x));
        animator.SetBool("OnGround", pMov.isGrounded);
    }
}
