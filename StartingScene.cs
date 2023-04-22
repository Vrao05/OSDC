using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Playables;


public class StartingScene : MonoBehaviour
{
    public PlayableDirector Timeline;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Timeline.state == PlayState.Paused)
        {
            SceneManager.LoadScene("Game1");
        }
    }
}
