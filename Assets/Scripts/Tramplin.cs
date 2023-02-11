using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Tramplin : MonoBehaviour
{
    public GameObject obj;
    
    public float Power;

    void Update()
    {
        Power = obj.GetComponent<Player_Move>().test;
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * (Power * -1), ForceMode2D.Impulse);
        }
    }
}
