using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    private Vector2 limitYPos = new Vector2(0, 3.5f);
    public Transform shootPoint;
    public Transform testPlayer;
    Vector3 playerPos;
    public GameObject bullet;

    public float random_xPos;

    private float fireRate;
    public const float constfireRate = 0.6f;

    public float shootTime = 5f;
    bool canShoot;
    bool hasSetAngle;


    void Awake()
    {

       

        random_xPos = Random.Range(-7.5f, 7.5f);

        
        
            testPlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        
        
        shootTime = 5f;
        fireRate = constfireRate;
    }

    // Update is called once per frame
    void Update()
    {
        fireRate -= Time.deltaTime;
        if(transform.position.y > 3.5f && !hasSetAngle)
        {
          transform.position = new Vector2(random_xPos, Mathf.Lerp(transform.position.y, 3.5f, 8 * Time.deltaTime));
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
                playerPos = testPlayer.transform.position;
                Vector3 direction = playerPos - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
                hasSetAngle = true;
               
                transform.eulerAngles = Vector3.forward * angle;
                
            }
            transform.Translate(-Vector3.up * -9f * Time.deltaTime);
        }
        
        if(transform.position.y < -7f)
        {
            Destroy(this.gameObject);
        }
        
    }

    void ShootBullet()
    {
        Vector3 direction = testPlayer.position - shootPoint.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90;
        shootPoint.eulerAngles = Vector3.forward * angle;
        Debug.DrawRay(shootPoint.position, direction, Color.green);
        Instantiate(bullet, shootPoint.position, Quaternion.Euler(0,0, shootPoint.eulerAngles.z));
    }
}
