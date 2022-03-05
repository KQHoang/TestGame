using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    int score;
    void Start()
    {
        score = 0;
    }
   
    private int width, height;
    void Awake()
    {
        width = Screen.width;
        height = Screen.height;
    }
    void OnGUI()
    {
        GUIStyle labelDetails = new GUIStyle(GUI.skin.GetStyle("label"));
        labelDetails.fontSize = 5 * (width / 200);
        GUI.Label(new Rect(width / 8, height / 2, width - (2 * width / 8), height -
        (2 * height / 4)),"Score: "+ score, labelDetails);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(gameObject);
            score++;
         
        }    
           
    }

}
