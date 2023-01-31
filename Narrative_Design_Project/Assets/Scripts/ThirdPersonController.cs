using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonController : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public float rotationSpeed = 5.0f;
    private Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Rotate(0, horizontal * rotationSpeed, 0);

        Vector3 moveDirection = transform.forward * vertical * moveSpeed;
        transform.position += moveDirection * Time.deltaTime;
    }
}

