using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(GameControl.instance.ScrollSpeed, 0);
    }

    
    void Update()
    {
        if(GameControl.instance.gameOver == true)
        {
            rb.velocity = Vector2.zero;
        }
    }
}
