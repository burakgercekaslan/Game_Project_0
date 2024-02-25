using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class Bird_Jump : MonoBehaviour
{
    public float Velocity = 1f;
    private bool isdead = false;
    float time;
    float timeDelay;
    public float Rotation_Speed = 10f;
    public Rigidbody2D rb2D;
    public GameManager managerGame;
    void Start()
    {
        time = 0f;
        timeDelay = 0.1f;
    }
    void Update()
    {
    if(isdead)
    {
        Time.timeScale = 0f;
    }
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
        transform.position = new Vector2(0,4.78f);
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
        transform.position = new Vector2(0,4.78f);
        rb2D.velocity = Vector2.down * Velocity/2;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
    if(collision.gameObject.tag == "DeathArea")
        {
        isdead = true;
        Time.timeScale = 0f;
        }
    }  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore()
        }
    }
}