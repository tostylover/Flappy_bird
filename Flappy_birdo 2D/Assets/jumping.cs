using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class jumping : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 50;
    public float jumping_force = 200;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * jumping_force);
        }
        if(Input.GetKeyUp(KeyCode.Q))
        {
            rb.AddForce(Vector3.left * speed);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            rb.AddForce(Vector3.right * speed);
        }
    }
}
