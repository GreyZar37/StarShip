﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void restart()
    {
        SceneManager.LoadScene(0);
        Score.score = 0;
    }
    public void exit()
    {
        Application.Quit();
    }
}
