using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;

public class SceneTransition : MonoBehaviour
{
    public PlayableDirector t2;
    public GameObject txt;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(t2.state == PlayState.Paused)
        {
            txt.SetActive(true);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene("OldValley");
    }
}
