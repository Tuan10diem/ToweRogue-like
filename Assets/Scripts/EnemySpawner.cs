using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class EnemySpawner : MonoBehaviour
{
    public SpawnPoint spawnPoints;
    public EnemySpawnerCtrl enemySpawnerCtrl;
    public EnemyType enemyType;
    private float time = 0f;
    public float delayTime = 2f;

    private void Awake()
    {
        spawnPoints = FindObjectOfType<SpawnPoint>();
        enemySpawnerCtrl = FindObjectOfType<EnemySpawnerCtrl>();
        enemyType = FindObjectOfType<EnemyType>();
    }

    private void Update()
    {
        time += 1 * Time.deltaTime;
        if (time < delayTime) return;
        time = 0;
        RandSpawn();
    }

    private void RandSpawn()
    {
        if (!enemySpawnerCtrl.checkNOfEnemy()) return;
        Transform randPoint = spawnPoints.RandomPoint();
        Vector3 randPos = randPoint.position;
        Quaternion randRot = transform.rotation;
        GameObject enemyTmp = enemyType.RandomTypes();
        GameObject enemy = Instantiate(enemyTmp, randPos, randRot);
        enemy.SetActive(true);
        enemySpawnerCtrl.increaseEnemy(1);
    }
    
}
