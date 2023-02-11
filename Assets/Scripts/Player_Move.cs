using System;
using System.Collections;
using System.Collections.Generic;
using Debug = UnityEngine.Debug;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public Rigidbody2D rb;
    public Vector2 moveVector;
    public float speed = 5f;
    public Animator anim;
    public SpriteRenderer sr;
    public bool faceRight = true;
    public float jumpForce = 7f;
    public float test;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        Debug.Log("Log is work");
    }

 
    void Update()
    {
        walk();
        //flip();
        Reflect();
        Jump();
        CheckingGround();
        test = rb.velocity.y;
        Debug.Log(test);
        if (onRed)
        {
            speed = 10f;
        }
        else
        {
            speed = 5f;
        }
    }

    void walk()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveVector.x * speed, rb.velocity.y);
        //rb.AddForce(moveVector * speed);
        anim.SetFloat("moveX", Math.Abs(moveVector.x));
        
    }

    void Reflect()
    {
        if ((moveVector.x > 0 && !faceRight) || (moveVector.x < 0 && faceRight))
        {
            transform.localScale *= new Vector2(-1, 1);
            faceRight = !faceRight;
        }
    }

    /* void flip()
     {
         if(moveVector.x > 0)
         {
             sr.flipX = false;
         }
         else if(moveVector.x < 0)
         {
             sr.flipX = true;
         }

         Короткий вид: sr.flipX = moveVector.x < 0;
     }*/


    void Jump()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W)) && (onGround || onRed))
        {
            //rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            rb.AddForce(Vector2.up * jumpForce);
        }
    }

    public bool onGround;
    public bool onRed;
    public Transform GroundCheck;
    public float checkRadius = 0.3f;
    public LayerMask Ground;
    public LayerMask RedSpeed;

    void CheckingGround()
    {
        
        onRed = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, RedSpeed);
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        anim.SetBool("onGround", onGround || onRed);
    }

}
