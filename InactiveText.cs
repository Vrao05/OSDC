using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InactiveText : MonoBehaviour
{
    public GameObject Textttt;
    void Start()
    {
        Invoke("SetInactiveText", 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void SetInactiveText()
    {
        Textttt.SetActive(false);
    }
}
