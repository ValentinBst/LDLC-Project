﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    [SerializeField]
    Vector3 positionDeDepart;
    float Vitesse;
    Rigidbody rigidbody;
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    Vector3 direction = new Vector3(0f, 0f, 1f);
    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        float speed = 2f;
        if (currentPosition.z > 9)
        {
            direction = new Vector3(0F, 0F, -1f);
        }
        if (currentPosition.z < -4)
        {
            direction = new Vector3(0F, 0F, 1f);
        }

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);
    }
}
