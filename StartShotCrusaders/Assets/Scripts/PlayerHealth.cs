using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;

    public GameObject healthImage;
    public GameObject healthImage2;
    public GameObject healthImage3;

    public GameObject gameOver;
    public GameObject gameStart;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth == 2)
        {
            healthImage.SetActive(false);
        }
        if (currentHealth == 1)
        {
            healthImage2.SetActive(false);
        }
        if (currentHealth == 0)
        {
            healthImage3.SetActive(false);
            gameOver.SetActive(true);
            gameObject.SetActive(false);

        }


    }
}
