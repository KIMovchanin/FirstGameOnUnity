using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_OF_Choosen : MonoBehaviour
{
    public Sprite ChangeOn1;
    public Sprite ChangeOn2;
    private SpriteRenderer sr;

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if(sr == null)
        {
            sr.sprite = ChangeOn1;
        }
    }

    void Update()
    {
        if(Input.GetKey("1"))
        {
            sr.sprite = ChangeOn1;
        }
        else if(Input.GetKey("2"))
        {
            sr.sprite = ChangeOn2;
        }
    }

}
