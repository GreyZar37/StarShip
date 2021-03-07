using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    public AudioSource soundEffect;

    float currentTimer;
    public float playerCoolDowntimer = 1.5f;


    void Update()
    {
        currentTimer -= Time.deltaTime;

        if (currentTimer <= 0)
        {
            currentTimer = 0;
        }

        if (Input.GetKey(KeyCode.Space) && currentTimer == 0)
        {
            shoot();
            currentTimer = playerCoolDowntimer;
            soundEffect.Play();
        }

        void shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
