using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 1;
    public float minDistanceFromPlayer = 10;

    public Transform playerTransform;
    private void Start()
    {
        InvokeRepeating("SpawnEnemy", 0, spawnInterval);
    }

    void SpawnEnemy()
    {
        Vector3 spawnPosition = playerTransform.position + minDistanceFromPlayer * Random.onUnitSphere;
        spawnPosition.y = 0;

        float distance = Vector3.Distance(spawnPosition, playerTransform.position);
        while (distance < minDistanceFromPlayer)
        {
            spawnPosition = playerTransform.position + minDistanceFromPlayer * Random.onUnitSphere;
            spawnPosition.y = 0;
            distance = Vector3.Distance(spawnPosition, playerTransform.position);
        }

        GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
    }
}
