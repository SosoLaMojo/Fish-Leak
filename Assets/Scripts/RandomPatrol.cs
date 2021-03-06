﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomPatrol : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float speed;

    private Vector2 targetPosition;

    private bool isFacingRight = true;
    
    const float oneSecond = 1.0f;
    float timer = 0f;
    [SerializeField] float speedIncreasement;
    const float restartTimer = 0;
    [SerializeField] float timeBeforeIncreasement;

    GameManager gameManager;

    void Start()
    {
        targetPosition = GetRandomPosition();
        //FindObjectOfType<SpawnRepulsif>().addFish();
        if (FindObjectOfType<SpawnRepulsif>() != null)
        {
            FindObjectOfType<SpawnRepulsif>().addFish();
        }
        //FindObjectOfType<Cooldown>();
        if (FindObjectOfType<Cooldown>() != null)
        {
            FindObjectOfType<Cooldown>().addFish();
        }

        gameManager = FindObjectOfType<GameManager>();
    }
    
    void Update()
    {
        if (Vector2.Distance(targetPosition, transform.position) > 0.1f)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
        
        IncreaseFishSpeed();
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        if (randomX < transform.position.x && isFacingRight)
        {
            transform.Rotate(0f, 180f, 0f);

            isFacingRight = false;
        }
        else if (randomX > transform.position.x && !isFacingRight)
        {
            transform.Rotate(0f, 180f, 0f);

            isFacingRight = true;
        }
        
        return new Vector2(randomX, randomY);
    }

    void IncreaseFishSpeed()
    {
        timer += oneSecond * Time.deltaTime;
        
        if (timer >= timeBeforeIncreasement)
        {
            speed += speedIncreasement;
            timer = restartTimer;
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {

            Vector3 vec = (collision.transform.position - transform.position);
            targetPosition = transform.position - vec;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gameManager.DeathFish();
        }
    }
}
