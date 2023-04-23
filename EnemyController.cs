using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    Animator anim;
    public static bool isBatDead;
    void Start()
    {
        anim = GetComponent<Animator>();
        isBatDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("IsDead", true);
            isBatDead = true;
        }
    }
    
}
