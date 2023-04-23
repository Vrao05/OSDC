using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HeroController : MonoBehaviour
{
   public float moveSpeed = 5f;
   Animator anim;
   Rigidbody2D rb;
   SpriteRenderer sr;
   public float jumpForce = 0.5f;
   public float JumpCooldown = 1.5f;
   float lastJumpTime = -Mathf.Infinity;
   int health;
   public bool Died;

   public List<GameObject> images = new List<GameObject>();  //life hearts
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim  = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        health = 5;
        Died = false;

        foreach (Transform child in transform)
        {
            if(child.gameObject.GetComponent<SpriteRenderer>()!=null)
            {
                images.Add(child.gameObject);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {   
        if(!Died)
        {
        float horizontalInput = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontalInput*moveSpeed,rb.velocity.y);


        if(Mathf.Abs(rb.velocity.x)>0)
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
        if(Time.time - lastJumpTime >= JumpCooldown && Input.GetButtonDown("Jump"))
        {   
            Jump();
            
        }
        
        }

        else
        {
            Invoke("LoadScene", 3f);
        }
    }
    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        lastJumpTime = Time.time;
    }
   public void HurtPlayer()
    {   
        if(health>0)
        {
        health--;
        }
        if(images.Count>0)
        {
            GameObject imageToRemove = images[0];
            images.RemoveAt(0);
            Destroy(imageToRemove);
        }
        anim.SetBool("IsHurt", true);
    }
   public  void HurtOver()
    {
        anim.SetBool("IsHurt", false);
    }
    public void KillPlayer()
    {
        if(health==0)
        {
            anim.SetBool("IsDead", true);
            Died = true;
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene("OldValley");
    }
}
