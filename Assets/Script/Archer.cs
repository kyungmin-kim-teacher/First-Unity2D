using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    public GameObject arrowObj;
    public Transform shootPosTf;
    public KeyCode shootingKey;
    public int power;

    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        int cc = Arrow.cnt;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.up * 500f);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject arrowCloneObj = Instantiate(arrowObj);
            arrowCloneObj.transform.position = shootPosTf.position;
            //arrowCloneObj.GetComponent<Rigidbody2D>().AddForce(new Vector2(-1, 1) * 300f);
        }
    }
}
