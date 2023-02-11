using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public GameObject Object_1, Object_2;
    public Camera camera;
    public string Ink_Color = "1";

    void Update()
    {

        if (Input.GetKeyDown("1"))
        {
            Ink_Color = "1";
        }
        if (Input.GetKeyDown("2"))
        {
            Ink_Color = "2";
        }

        if (Input.GetMouseButton(0) && Ink_Color == "1")
        {
            Instantiate(Object_1, camera.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward, Quaternion.identity);
        }
        if (Input.GetMouseButton(0) && Ink_Color == "2")
        {
            Instantiate(Object_2, camera.ScreenToWorldPoint(Input.mousePosition) + Vector3.forward, Quaternion.identity);
        }
    }
}
