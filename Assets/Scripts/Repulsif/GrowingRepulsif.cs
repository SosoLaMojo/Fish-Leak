﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowingRepulsif : MonoBehaviour
{
    Vector3 growingScale = new Vector3(3.0f, 3.0f, 3.0f);
    float grownTimer;
    [SerializeField] float speedTime;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, growingScale, Time.deltaTime*speedTime);
        if (transform.localScale.x >= 2.9)
        {
            grownTimer -= Time.deltaTime;
            Destroy(gameObject);
        }

    }
}