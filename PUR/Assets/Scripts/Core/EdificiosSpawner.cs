using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class EdificiosSpawner : MonoBehaviour
{
    // References
    [SerializeField] private GameObject[] edificios;
    private Transform spawnPosition;
    private GameObject lastSpawn;

    private float timeElapsedSinceLastSpawnedObject = 0f;
    [SerializeField] private float spawnRateTime = 3f;
    [SerializeField] private float lastPositionSpawn = 36.4f;
    private void Start()
    { 
        SpawnObstacle();
    }
    private void Awake()
    {
        spawnPosition = GetComponent<Transform>();
    }


    private void Update()
    {
        /*timeElapsedSinceLastSpawnedObject += Time.deltaTime;
        if (timeElapsedSinceLastSpawnedObject > spawnRateTime)
        {
            timeElapsedSinceLastSpawnedObject = 0f;
            SpawnObstacle();
        }*/
        if(lastSpawn.transform.position.x < (spawnPosition.transform.position.x + lastPositionSpawn)){
            SpawnObstacle();
        }

    }

    private void SpawnObstacle()
    {
        int random = Random.Range(0, edificios.Count());
        GameObject obstacle = Instantiate(edificios[random],spawnPosition);
        lastSpawn = obstacle;
    }
}
