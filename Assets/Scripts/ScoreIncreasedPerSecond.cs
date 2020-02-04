using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreIncreasedPerSecond : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI scoreText;
    float floatScoreAmount = 0;
    int scoreAmount = 0;
    [SerializeField] float pointIncreasePerSecond; 
    const float oneSecond = 1.0f;
    float timer = 0f;
    [SerializeField] float pointIncreasement;
    const float restartTimer = 0;
    [SerializeField] float timeBeforeIncreasement;

    void Update()
    { 
        IncreaseScore();
        IncreasePointsPerSecond();
    }

    void IncreaseScore()
    {
        floatScoreAmount += pointIncreasePerSecond * Time.deltaTime;
        scoreAmount = (int)floatScoreAmount;
        scoreText.text = scoreAmount.ToString();
    }

    void IncreasePointsPerSecond()
    {
        timer += oneSecond * Time.deltaTime;
        
        if (timer >= timeBeforeIncreasement)
        {
            pointIncreasePerSecond += pointIncreasement;
            timer = restartTimer;
        }
    }
}