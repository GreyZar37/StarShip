
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parralel : MonoBehaviour
{
    public Transform[] backgrounds;
    private Camera cam;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        

        if(PlayerHealth.currentHealth > 0)
        {

            backgrounds[0].Translate(-Vector3.up * 5f * Time.deltaTime);
            backgrounds[1].Translate(-Vector3.up * 5f * Time.deltaTime);

            if (backgrounds[0].position.y < -11.45f)
            {
                backgrounds[0].position = new Vector3(-0.077f, 12.8f, 2);

            }
            if (backgrounds[1].position.y < -11.45f)
            {
                backgrounds[1].position = new Vector3(-0.077f, 12.8f, 2);

            }
        }

      
    }
}
        

