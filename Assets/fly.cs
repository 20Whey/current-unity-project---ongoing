﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour
{
    float speed = 5f;
    Vector3 velocity = new Vector3(0f, 0f, 0f);
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void FixedUpdate()
    {
        velocity = transform.up * speed;
        transform.position = transform.position + velocity;
    }

}