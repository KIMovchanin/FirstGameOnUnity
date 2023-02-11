using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ink_Jump : MonoBehaviour
{
    public float Power = 10f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * Power, ForceMode2D.Impulse);
        }
    }
}
