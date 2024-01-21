using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird_Jump : MonoBehaviour
{
    public float Velocity = 1f;
    float time;
    float timeDelay;

    private float y = 4.78f;
    public float Rotation_Speed = 10f;
    public Rigidbody2D rb2D;
    void Start()
    {
        time = 0f;
        timeDelay = 0.2f;
    }
    void Update()
    {
    time = time + 1f* Time.deltaTime;
    if(Input.GetMouseButtonDown(0))
    {
        
    
        if (time >= timeDelay)
        {
            time = 0f;
            rb2D.velocity = Vector2.up * Velocity;
        
        }
    }
    if (transform.position.y > 4.78f)
    {
        transform.position = new Vector2(0,y);
        rb2D.velocity = Vector2.down * Velocity/2;
    }
    }
    private void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0,0,Rotation_Speed*rb2D.velocity.y);
    }
        private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Ceiling")
        {
            transform.position = new Vector2(0,y);
            rb2D.velocity = Vector2.down * Velocity/2;
        }
    }
}
