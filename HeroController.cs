using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour
{
   public float moveSpeed = 5f;
   Animator anim;
   Rigidbody2D rb;
   SpriteRenderer sr;
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

        
    }
}
