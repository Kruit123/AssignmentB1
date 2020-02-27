using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class aswdmovement : MonoBehaviour
{
public float speed;
private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
	}

    void PlayerMovement()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector3.left * speed);

        }

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);

        }

    }
	    void Update()
    {
        PlayerMovement();
    }
}