using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawnerCtrl : MonoBehaviour
{
    public static AttackerSpawnerCtrl instance;

    public AttackerSpawner _AttackerSpawner;
    public int numberOfEnemy = 0;
    public int maxEnemy = 20;
    // Start is called before the first frame update

    private void Awake()
    {
        _AttackerSpawner = GetComponent<AttackerSpawner>();
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
