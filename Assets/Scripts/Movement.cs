using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
    }

    public void Update()
    {
        float appleSpeed = Time.deltaTime * speed;

        if (Input.GetKey(KeyCode.W))
        {
            transform.position = transform.position + new Vector3(0, 0, appleSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position = transform.position + new Vector3(0, 0, -appleSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-appleSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(appleSpeed, 0, 0);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, appleSpeed, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            transform.position += new Vector3(0, -appleSpeed, 0);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.useGravity = !rb.useGravity;
        }
    }
}