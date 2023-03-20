using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerCtrl : MonoBehaviour
{
    public static EnemySpawnerCtrl instance;
    
    public int numberOfEnemy = 0;
    public int maxEnemy = 20;
    // Start is called before the first frame update

    private void Awake()
    {
        instance = this;
    }

    public void increaseEnemy(int n)
    {
        numberOfEnemy+=n;
    }

    public void decreaseEnemy(int n)
    {
        numberOfEnemy -= n;
    }

    public bool checkNOfEnemy()
    {
        return numberOfEnemy < maxEnemy;
    }
}
