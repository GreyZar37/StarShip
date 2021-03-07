using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Astroide : MonoBehaviour
{
    public GameObject playerPosition;
    private float timeCounter = 0;
    public float speed;
    public float width;
    public float hight;
    void Start()
    {

    }


    void Update()
    {
        float playerX = playerPosition.transform.position.x;
        float playerY = playerPosition.transform.position.y;

        timeCounter += Time.deltaTime*speed;

        float x = Mathf.Cos(timeCounter)*width;
        float y = Mathf.Sin(timeCounter)*hight;
        float z = 0;

        transform.position = new Vector3(x + playerX, y + playerY, z);

        if(PlayerHealth.currentHealth <= 0)
        {
            Destroy(gameObject);
        }
    }

    
    private void OnTriggerEnter(Collider other)
    {


        if (other.gameObject.CompareTag("Enemies"))
        {
            Destroy(other.gameObject);
            Score.score++;
        }

        if (other.gameObject.CompareTag("EnemyBullet"))
        {
            Destroy(other.gameObject);
        }


    }
}
