using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int maxHealth = 3;
    public static int currentHealth;

    public GameObject healthImage;
    public GameObject healthImage2;
    public GameObject healthImage3;

    public GameObject gameOver;
    public GameObject gameStart;

   

    public GameObject boomSound;


    // Start is called before the first frame update
    public void Start()
    {

        boomSound = GameObject.FindGameObjectWithTag("Sound");
        
        
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    public void Update()
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
           
            boomSound.GetComponent<AudioSource>().Play();

        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            currentHealth--;
        }
    }
}
