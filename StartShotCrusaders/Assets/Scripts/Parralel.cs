
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


    float distanceFromSubject => transform.position.z - subject.position.z;
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));
    float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;

    public Transform[] backgrounds;
    private Camera cam;


    Float startZ;


    void Start()
    {
        cam = Camera.main;
    }

    void Update()


        backgrounds[0].Translate(-Vector3.up * 10f * Time.deltaTime);
        backgrounds[1].Translate(-Vector3.up * 10f * Time.deltaTime);

        if (backgrounds[0].position.y < -11.45f)
        {
            backgrounds[0].position = new Vector3(0, 12.7f, 0);

        }
        if (backgrounds[1].position.y < -11.45f)
        {
            backgrounds[1].position = new Vector3(0, 12.7f, 0);

        }
    }
}
