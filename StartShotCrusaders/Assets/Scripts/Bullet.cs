using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public static int playerDamage;
    public float bulletDestroyTime;
    private float currentTimer;


    private Rigidbody rb;


    private void Awake()
    {
        currentTimer = bulletDestroyTime;
        rb = GetComponent<Rigidbody>();
    }
    private void Update()
    {   
        rb.velocity = transform.up * 9f;


        rb.velocity = transform.up * 25f;

        currentTimer -= Time.deltaTime;

        if(currentTimer <= 0)
        {
            Destroy(gameObject);
        }

        rb.velocity = transform.up * 9f;

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")

        {
            Destroy(gameObject);
           // other.gameObject.GetComponent<EnemyHealth>().TakeDamage(playerDamage);

        }

    }
}
