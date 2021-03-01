using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyOne : MonoBehaviour
{
    private Vector2 limitYPos = new Vector2(0, 3.5f);
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 3.5f)
        {
           transform.position = new Vector2(0, Mathf.Lerp(transform.position.y, limitYPos.y, 8 * Time.deltaTime));
        }

        if( transform.position.y < 3.51f)
        {
            print("PEW PEW!");
        }
    }
}
