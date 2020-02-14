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

    [SerializeField] int maxScoreLevel1 = 100;
    [SerializeField] GameObject panelLvlUp;

    void Update()
    { 
        IncreaseScore();
        IncreasePointsPerSecond();
        PanelNextLevel();
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

    void PanelNextLevel()
    {
        if(scoreAmount >= maxScoreLevel1)
        {
            panelLvlUp.SetActive(true);
        }
    }
}