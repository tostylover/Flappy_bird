using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    Rigidbody rb;
    public float speed = 2;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(x, 0, z);

        transform.Translate(movement * speed * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * 300);
        }

    }
}
