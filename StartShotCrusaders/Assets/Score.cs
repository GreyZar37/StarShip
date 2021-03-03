using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update


    public static int score = 0;
    public TextMeshProUGUI scoreTextIngame;
    public TextMeshProUGUI scoreTextOutgame;
    


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTextIngame.text = "Score: " + score.ToString();



    }
}
