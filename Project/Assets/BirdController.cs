using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public Rigidbody2D rb2d;
    public float JumpForce;


    void Start()
    {
        Debug.Log("hello");
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //Debug.Log("Jump pressed");
            rb2d.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
    }
}