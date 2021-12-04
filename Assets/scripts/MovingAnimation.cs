using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingAnimation : MonoBehaviour
{
    Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        // if player press on one of the "WASD" buttons the animation will start
        if (Input.GetKey(KeyCode.W))
        {
            // set IsRunning to true
            animator.SetBool("Moving", true);
        }
        if (!Input.GetKey(KeyCode.W))
        {
            // set IsRunning false
            animator.SetBool("Moving", false);
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Sprinting", true);
        }

        if (!Input.GetKey(KeyCode.W) || !Input.GetKey(KeyCode.LeftShift))
        {
            animator.SetBool("Sprinting", false);
        }
    }
}
