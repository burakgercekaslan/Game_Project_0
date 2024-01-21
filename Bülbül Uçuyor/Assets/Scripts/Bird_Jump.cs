using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Jump : MonoBehaviour
{
    public float Velocity = 1f;
    public float Rotation_Speed = 10f;
    public Rigidbody2D rb2D;
    void Update()
    {
    if(Input.GetMouseButtonDown(0))
    {
        rb2D.velocity = Vector2.up * Velocity;
    }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,Rotation_Speed*rb2D.velocity.y);
    }
}
