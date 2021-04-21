﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 20;

    public int enemyCount;
    public int waveNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        SpawnEnemyWave(waveNumber);
    }

    // Update is called once per frame
    void Update()
    {
        enemyCount = FindObjectsOfType<Enemy>().Length;
        //If 0 enemies are in game, then the next wave will spawn more enemies
        if(enemyCount == 0)
        {
            waveNumber ++;
            SpawnEnemyWave(waveNumber);
        }
    }
   
    private Vector3 GenerateSpawnPosition()
    {
        //Generates the random positions of enemies
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 1.3f, spawnPosZ);

        return randomPos;
    }

    void SpawnEnemyWave(int enemiesToSpawn)
    {
        //Spawn variables for each enemy waves
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }
}
