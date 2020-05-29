using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavespawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public float timeBetweenWaves = 10f;
    private float countdown = 5f;

    void Update()
    {
        if (countdown <= 0)
        {
            SpawnWave();
            countdown = timeBetweenWaves;
        }

        countdown -= Time.deltaTime;
    }

    void SpawnWave()
    {
        Debug.Log("Wave incoming!");
    }
}
