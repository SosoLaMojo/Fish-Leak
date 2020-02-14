using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRepulsif : MonoBehaviour
{
    [SerializeField] SO_Repulsif repulsif;
    [SerializeField] Transform repulsifSpawn;

    float currentDelay = 0.0f;
    float delayWaveSpawn = 0.1f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (currentDelay > 0)
        {
            currentDelay -= Time.deltaTime * delayWaveSpawn;
        }

        if (Input.GetButton("Fire1"))
        {
            if (currentDelay <= 0)
            {
                Fire(transform, repulsifSpawn);
                currentDelay = repulsif.Delay;
            }
        }
    }
    void Fire(Transform transform, Transform repulsifSpawn)
    {
        for (int i = 0; i < repulsif.Numb; i++)
        {
            GameObject Repulsif = Instantiate(repulsif.PrefabRepulsif, repulsifSpawn);
            Repulsif.transform.parent = null;
            Repulsif.transform.localScale = Vector3.one;

            //laserGreen.transform.position += (Vector3)Random.insideUnitCircle * repulsif.Dispertion;

            //laserGreen.GetComponent<Rigidbody2D>().velocity = transform.right * repulsif.BulletSpeed;

        }
    }
}
