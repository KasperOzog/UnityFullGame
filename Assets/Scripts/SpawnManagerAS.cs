using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerAS : MonoBehaviour
{
    public GameObject[] asteroidPrefab;

    private float spawnLimitLeft = -28;
    private float spawnLimitRight = 20;
    private float spawnPosY = 0;

    private float startDelay = 0.1f;
    private float spawnInterval = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
    }

    // Spawn random asteroid at random x position at top of play area
    void SpawnObstacle()
    {
        spawnInterval = Random.Range(2, 4);

        // Generate random asteroid index and random spawn position
        int index = Random.Range(0, asteroidPrefab.Length);
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitLeft, spawnLimitRight), spawnPosY, 0);

        // instantiate asteroid at random spawn location
        Instantiate(asteroidPrefab[index], spawnPos, asteroidPrefab[index].transform.rotation);
    }

}