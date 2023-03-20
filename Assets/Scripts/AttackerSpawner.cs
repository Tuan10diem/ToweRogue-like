using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    public AttackerSpawnPoint spawnPoints;
    public AttackerType enemyType;
    private float time = 0f;
    public float delayTime = 2f;

    private void Awake()
    {
        spawnPoints = FindObjectOfType<AttackerSpawnPoint>();
        enemyType = FindObjectOfType<AttackerType>();
    }

    private void Update()
    {
        Spawn();
    }

    public void Spawn()
    {
        time += 1 * Time.deltaTime;
        if (time < delayTime) return;
        time = 0;
        RandSpawn();
    }

    private void RandSpawn()
    {
        if (!AttackerSpawnerCtrl.instance.checkNOfEnemy()) return;
        Transform randPoint = spawnPoints.RandomPoint();
        Vector3 randPos = randPoint.position;
        Quaternion randRot = transform.rotation;
        GameObject enemyTmp = enemyType.RandomTypes();
        GameObject enemy = Instantiate(enemyTmp, randPos, randRot);
        if (randPoint.name == "RightPoint") enemy.GetComponent<SpriteRenderer>().flipX = true;
        enemy.SetActive(true);
        AttackerSpawnerCtrl.instance.increaseEnemy(1);
    }
}
