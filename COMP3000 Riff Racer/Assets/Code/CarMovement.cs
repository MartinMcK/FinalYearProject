﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    public Rigidbody rb;
    public Transform car;
    public float speed = 17;

    Vector3 forward = new Vector3(0, 0, 1);
    Vector3 backward = new Vector3(0, 0, -1);

    Vector3 rotationRight = new Vector3(0, 30, 0);
    Vector3 rotationLeft = new Vector3(0, -30, 0);

    void FixedUpdate()
    {
        if (Input.GetKey("w"))
        {
            rb.MovePosition(car.position + forward * speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.MovePosition(car.position + backward * speed * Time.deltaTime);
        }

        if (Input.GetKey("d"))
        {
            Quaternion deltaRotationRight = Quaternion.Euler(rotationRight * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationRight);
        }

        if (Input.GetKey("a"))
        {
            Quaternion deltaRotationLeft = Quaternion.Euler(rotationLeft * Time.deltaTime);
            rb.MoveRotation(rb.rotation * deltaRotationLeft);
        }

    }
}