/*
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

    Float startZ;

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