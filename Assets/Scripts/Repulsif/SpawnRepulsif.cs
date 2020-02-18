using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRepulsif : MonoBehaviour
{
    [SerializeField] GameObject repulsif;
    [SerializeField] Transform repulsifSpawn;
    bool spawned;
    [SerializeField] int actualCooldown;
    int baseCooldown = 20;
    int secondPerFish = 2;
    [SerializeField] int fish = 4;

void Update()
    {
    }

    public void spawnRepulsif(Transform repulsifSpawn)
    {
        if (!spawned)
        {
            Instantiate(repulsif, transform.position, Quaternion.identity);
            StartCoroutine(cooldown());
        }
    }
    public IEnumerator cooldown()
    {
        actualCooldown = baseCooldown - secondPerFish * fish;
        spawned = true;
        yield return new WaitForSeconds(actualCooldown);
        spawned = false;
        Debug.Log("finish");
    }
}
