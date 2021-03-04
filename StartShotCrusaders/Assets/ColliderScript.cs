using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderScript : MonoBehaviour
{

    public float viewRadius;
    public float viewAngle;

    public LayerMask targetMask;

    public void Start()
    {
        

    }
    

    public List<Transform> visibleTargets = new List<Transform>();

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
