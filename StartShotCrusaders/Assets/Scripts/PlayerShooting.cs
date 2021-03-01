using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;


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
        }

        void shoot()
        {
            GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        }
    }
}
