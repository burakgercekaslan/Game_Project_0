using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Jump : MonoBehaviour
{
    public float velocity = 1f;
    public float _rotationspeed = 10f;
    public Rigidbody2D rb2D;
    void Update()
    {
    if(Input.GetMouseButtonDown(0))
    {
        rb2D.velocity = Vector2.up * velocity;
    }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,_rotationspeed*rb2D.velocity.y);
    }
}
