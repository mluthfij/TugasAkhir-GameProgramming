using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackController : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        if (!PauseScript.isPaused)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        animator.SetTrigger("Attack");
        SoundManagerScript.PlaySound("fire");
    }
}
