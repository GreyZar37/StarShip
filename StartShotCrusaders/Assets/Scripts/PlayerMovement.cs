﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 5f;
    Vector3 movement;
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
       

    }
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement.normalized * playerSpeed * Time.fixedDeltaTime);

    }
}
