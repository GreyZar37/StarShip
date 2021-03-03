﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralel : MonoBehaviour
{
    public Camera cam;
    public Transform subject;
    private float startZ;
    Vector2 startPosition;
    Vector2 travel => (Vector2)cam.transform.position - startPosition;

    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));
    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;
    

    void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    void Update()
    {
        Vector2 newPos = startPosition + travel * 0.9f;
        transform.position = new Vector3(newPos.x, newPos.y, startZ);
    }
}