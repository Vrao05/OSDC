using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timeline : MonoBehaviour
{
   public bool killhim;
   Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
        killhim = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(killhim)
        {
            anim.SetBool("Kill", true);
        }
        else
        {
            anim.SetBool("Kill", false);
        }
    }
}
