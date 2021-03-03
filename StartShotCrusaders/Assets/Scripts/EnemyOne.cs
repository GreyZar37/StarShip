using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    private Vector2 limitYPos = new Vector2(0, 3.5f);
    public Transform shootPoint;
    public Transform testPlayer;
    public GameObject bullet;

    private float fireRate;
    public const float constfireRate = 0.25f;

    public float shootTime = 5f;
    bool canShoot;
    bool hasSetAngle;
    void Start()
    {
        shootTime = 5f;
        fireRate = constfireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRate -= Time.deltaTime;
        if(transform.position.y > 3.5f && !hasSetAngle)
        {
           transform.position = new Vector2(0, Mathf.Lerp(transform.position.y, 3.5f, 8 * Time.deltaTime));
        }
        if(shootTime > 0f)
        {
            if (transform.position.y < 3.51f)
            {
                canShoot = fireRate < 0;
                if (canShoot)
                {
                    fireRate = constfireRate;
                    ShootBullet();
                }
                shootTime -= Time.deltaTime;

            }
        }
        else
        {
            if (!hasSetAngle)
            {
                Vector2 dir = new Vector2(shootPoint.position.x - testPlayer.position.x, shootPoint.position.y - testPlayer.position.y);
                hasSetAngle = true;
                transform.up = dir;
                
            }
            transform.Translate(transform.up * -9f * Time.deltaTime);
        }
        
        if(transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }
        
    }

    void ShootBullet()
    {

        Vector2 dir = new Vector2(shootPoint.position.x - testPlayer.position.x, shootPoint.position.y - testPlayer.position.y);
        shootPoint.up = dir;

        Instantiate(bullet, shootPoint.position, Quaternion.Euler(0,0,180 + shootPoint.rotation.eulerAngles.z));
    }
}
