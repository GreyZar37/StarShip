using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTwo : MonoBehaviour
{
    public GameObject Bomb;
    private Vector2 endPos;
    public GameObject testPlayer;
    void Awake()
    {
        endPos = testPlayer.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
