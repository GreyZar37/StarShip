using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public static int playerDamage;


    private Rigidbody2D rb;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
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
