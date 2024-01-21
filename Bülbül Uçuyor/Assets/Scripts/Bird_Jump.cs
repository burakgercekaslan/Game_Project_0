using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Jump : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    void Update()
    {
    if(Input.GetMouseButtonDown(0))
    {
        rb2D.velocity = Vector2.up * velocity;
    }
    }
}
