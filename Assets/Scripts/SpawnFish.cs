using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFish : MonoBehaviour
{
    [SerializeField] private GameObject[] fish;
    [SerializeField] float pointIncreasePerSecond;
    [SerializeField] float pointIncreasement;
    [SerializeField] float timeBeforeIncreasement;

    float floatScoreAmount = 0;
    float timer = 0;
    const float thirdSeconds = 30.0f;
    const float restartTimer = 0;
    int scoreAmount = 0;

    private void Update()
    {
        TimerSpawnFish();
    }

    private void SpawnRandom()
    {
        int index = Random.Range(0, fish.Length);
        Instantiate(fish[index], transform.position, Quaternion.identity);
    }

    void TimerSpawnFish()
    {
        timer += Time.deltaTime;
        if (timer >= timeBeforeIncreasement)
        {
            pointIncreasePerSecond += pointIncreasement;
            SpawnRandom();
            timer = restartTimer;
        }
    }
}
