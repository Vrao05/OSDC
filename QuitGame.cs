using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class QuitGame : MonoBehaviour
{
    public PlayableDirector pd;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(pd.state==PlayState.Paused)
        {
            Application.Quit();
        }
    }
   public  void OnclickExit()
    {
        Application.Quit();
    }
}
