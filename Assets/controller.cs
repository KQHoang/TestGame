using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private int dichuyen;
    private float speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            dichuyen = -1;
            speed = 1;
        }    
        if(Input.GetKey(KeyCode.RightArrow))
        {
            dichuyen = 1;
            speed = 1;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * 10);
                 
        }
         

    }
    private void FixedUpdate()
    {
        if(dichuyen == -1)
        {
            rb.transform.Translate(Vector2.left  * Time.deltaTime);
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }
        if(dichuyen == 1)
        {
            rb.transform.Translate(Vector2.right * Time.deltaTime);
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
    }
}
