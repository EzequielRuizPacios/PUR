using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class ObstacleSpawner : MonoBehaviour
{
    // References
    [SerializeField] private GameObject[] obstacles;
    private Transform spawnPosition;

    private float timeElapsedSinceLastSpawnedObject = 0f;
    [SerializeField] private float spawnRateTime = 3f;

    private void Start()
    {
        //SpawnObstacle();
    }
    private void Awake()
    {
        spawnPosition = GetComponent<Transform>();
    }


    private void Update()
    {
        
        timeElapsedSinceLastSpawnedObject += Time.deltaTime;
        if (timeElapsedSinceLastSpawnedObject > spawnRateTime)
        {
            timeElapsedSinceLastSpawnedObject = 0f;
            SpawnObstacle();
        }
    }

    private void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Count());
        GameObject obstacle = Instantiate(obstacles[random],spawnPosition);
    }
}
