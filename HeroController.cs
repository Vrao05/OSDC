using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
   public float moveSpeed = 5f;
   Animator anim;
   Rigidbody2D rb;
   SpriteRenderer sr;
   public float jumpForce = 0.5f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim  = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontalInput*moveSpeed,rb.velocity.y);


        if(rb.velocity.magnitude>0)
        {
            anim.SetBool("IsWalking", true);
            
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        if(rb.velocity.x !=0)
        {
            sr.flipX = rb.velocity.x < 0;
        }
        if(Input.GetButtonDown("Jump"))
        {   
            // anim.SetBool("Jump", true);
            // Invoke("StopJump", 1.5f);
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
        
    }
    // void StopJumpAnim()q
    // {
    //     anim.SetBool("Jump", false);
    // }
}
