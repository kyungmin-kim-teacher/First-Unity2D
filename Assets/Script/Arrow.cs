using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    public static int cnt = 0;
    // Start is called before the first frame update
    void Start()
    {
        cnt++;
        Debug.Log("Hi Arrow " + cnt);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(new Vector2(-1, 1) * 3f);
    }
}
