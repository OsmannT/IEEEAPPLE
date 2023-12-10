using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    public float Height;

    private void LateUpdate()
    {
        transform.position = followTarget.position;

        Vector3 newPosition = transform.position;

        newPosition.y = Mathf.Clamp(newPosition.y, Height, Height);

        transform.position = newPosition;
    }
    //elma kopya olarak oluþtuktan sonra kameranýn nasýl takip edeceðini bulamadým elma spawnlandýktan sonra main cameradaki scripte elmadaki followcamerayý atamadým otomatik olarak ondan direkt movement scriptindeki kodu buraya attým

    //public float speed;
    //public void Update()
    //{
    //    float appleSpeed = Time.deltaTime * speed;

    //    if (Input.GetKey(KeyCode.W))
    //    {
    //        transform.position = transform.position + new Vector3(0, 0, appleSpeed);
    //    }

    //    if (Input.GetKey(KeyCode.S))
    //    {
    //        transform.position = transform.position + new Vector3(0, 0, -appleSpeed);
    //    }

    //    if (Input.GetKey(KeyCode.A))
    //    {
    //        transform.position = transform.position + new Vector3(-appleSpeed, 0, 0);
    //    }

    //    if (Input.GetKey(KeyCode.D))
    //    {
    //        transform.position = transform.position + new Vector3(appleSpeed, 0, 0);
    //    }
    //}
}