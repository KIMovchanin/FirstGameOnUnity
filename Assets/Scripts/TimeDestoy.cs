using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDestoy : MonoBehaviour
{
    public float StartTime;
    public float EndTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartTime += 0.1f * Time.deltaTime;

        if(StartTime >= EndTime)
        {
            Destroy(gameObject);
        }
    }
}
