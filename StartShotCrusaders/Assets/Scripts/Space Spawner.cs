using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject Background;
    private int AmountsofSpawnedBackground;
    private float travelDistance;
    private float speed;
    public float desiredDistance;
    public float z;

    void Start()
    {

    }

    void Update()
    {
        travelDistance += speed * Time.deltaTime;
        if (travelDistance > desiredDistance)
        {
            GameObject spawnedBackground = Instantiate(Background);
            spawnedBackground.transform.position = Vector3.forward * (desiredDistance + (travelDistance * (float) AmountsofSpawnedBackground));
            travelDistance = 0;
        }
    }
}
