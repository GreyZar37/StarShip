﻿/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralel : MonoBehaviour
{
    public camera cam;
    public transform subject;

    Vector2 startPosition;
    Vector2 travel => (vector2)cam.transform.position - startPosition;
    Vector2 parallexFactor;

<<<<<<< Updated upstream
    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));
    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;
    
=======
    Float startZ;
>>>>>>> Stashed changes

    void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }

    void Update()
    {
        transform.position = startPosition + travel;
    }
}
*/