using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class RandomPatrol : MonoBehaviour
{
    private Rigidbody2D body;
    
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float speed;

    private Vector2 targetPosition;
    
    
    void Start()
    {
        targetPosition = GetRandomPosition();

        body = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if ((Vector2) transform.position != targetPosition)
        {
            transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
        }
        else
        {
            targetPosition = GetRandomPosition();
        }
        
        Flip();
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        
        return new Vector2(randomX, randomY);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    private void Flip()
    {
        if (body.velocity.x > 0f)
        {
            transform.Rotate(0f, 180.0f, 0f);
        }
        else if (body.velocity.x < 0f)
        {
            transform.Rotate(0f, 180.0f, 0f);
        }
    }
}
