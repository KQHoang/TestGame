using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGaming : MonoBehaviour
{
    // Start is called before the first frame update
    public void Next()
    {
        Application.LoadLevel("Gaming");
    }
    public void Reload()
    {
        Application.LoadLevel("Main");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
