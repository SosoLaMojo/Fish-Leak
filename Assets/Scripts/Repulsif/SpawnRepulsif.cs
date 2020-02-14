using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRepulsif : MonoBehaviour
{
    //[SerializeField] SO_Repulsif repulsif;
    [SerializeField] GameObject repulsif;
    [SerializeField] Transform repulsifSpawn;
    float currentDelay = 0.0f;
    float delayWaveSpawn = 0.1f;


    void Start()
    {
        
    }

    void Update()
    {

    }
    public void spawnRepulsif(Transform repulsifSpawn)
    {
        Instantiate(repulsif, transform.position, Quaternion.identity);
    }
}
