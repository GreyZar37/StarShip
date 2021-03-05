using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{



    public float spawnTime;
    float currentTime;

    public GameObject prefab;

    // Start is called before the first frame update
    void Start()
    {
        currentTime = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;

        if(currentTime <= 0)
        {
            Instantiate(prefab);
            currentTime = spawnTime;
        }
    }
}
