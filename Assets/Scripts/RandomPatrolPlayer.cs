using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPatrolPlayer : MonoBehaviour
{
    [SerializeField] private float minX;
    [SerializeField] private float maxX;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;
    [SerializeField] private float speed;

    private Vector2 targetPosition;
    
    
    void Start()
    {
        targetPosition = GetRandomPosition();
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
    }

    Vector2 GetRandomPosition()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        
        return new Vector2(randomX, randomY);
    }
}
