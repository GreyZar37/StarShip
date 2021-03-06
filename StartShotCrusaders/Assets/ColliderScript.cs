using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    public float viewRadius;
    public float viewAngle = 360;

    public LayerMask interactable;
    public Collider[] targetsinRange;
    

    public void Start()
    {
        

    }

    private void Update()
    {
        Collision();
    }


    void Collision()
    {
        targetsinRange = Physics.OverlapSphere(transform.position, viewRadius, interactable);

        for (int i = 0; i < targetsinRange.Length; i++)
        {
            Transform target = targetsinRange[i].transform;

            Vector3 dirToTarget = (target.position - transform.position).normalized;
            if(Vector3.Angle (transform.forward, dirToTarget) < viewAngle / 2)
            {
                Vector3 direction = target.position - transform.position;

                float distToTarget = Mathf.Sqrt(Mathf.Pow(direction.x, 2) * Mathf.Pow(direction.y, 2));

                RaycastHit hit;

                if(!Physics.Raycast (transform.position,  dirToTarget, out hit, distToTarget, interactable))
                {

                    if (targetsinRange[i].gameObject.tag == "Enemies" && transform.gameObject.tag == "Player")
                    {
                        Destroy(targetsinRange[i].gameObject);


                        PlayerHealth.currentHealth--;
                        print("NIGGA moment");

                   
                    }
                   
                    else if (targetsinRange[i].gameObject.tag == "Enemies" && transform.gameObject.tag == "Bullet")
                    {
                        Destroy(targetsinRange[i].gameObject);
                        Destroy(transform.gameObject);

                        print("NIGGA Enemy");
                    }
                    else if (targetsinRange[i].gameObject.tag == "Player" && transform.gameObject.tag == "Bullet")
                    {
                        Destroy(targetsinRange[i].gameObject);
                        print("NIGGA bullet");

                        PlayerHealth.currentHealth--;

                        
                    }

                    
                }
            }
        }
    }

    // Start is called before the first frame update
    public Vector3 DirFormAngle(float angleInDegree, bool angleIsGlobal)
    {
        if (!angleIsGlobal)
        {
            angleInDegree += transform.eulerAngles.y;
        }
        return new Vector3(Mathf.Sin(angleInDegree * Mathf.Deg2Rad), 0, Mathf.Cos(angleInDegree * Mathf.Deg2Rad));
    }
}
