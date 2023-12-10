using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AppleSpawn : MonoBehaviour
{
    [SerializeField] private GameObject applePrefab;
    private Rigidbody rb;
    [SerializeField] private Transform followTarget;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            transform.position = followTarget.position;

            rb.useGravity = !rb.useGravity;
        } 
            if (collision.gameObject.CompareTag("Ground"))
        {
            transform.position = followTarget.position;

            rb.useGravity = !rb.useGravity;
        }
    }
}
