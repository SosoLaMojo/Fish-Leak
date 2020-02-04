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

    void Update()
    { 
        floatScoreAmount += pointIncreasePerSecond + Time.deltaTime;
        scoreAmount = (int)floatScoreAmount;
        scoreText.text = scoreAmount.ToString();
    }
}