using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float LifePower = 0.1f;

    // Start is called before the first frame update
    void Start()
    { 
        GetComponent<SpriteRenderer>().color = Color.yellow; 
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
