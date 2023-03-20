using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerCtrl : MonoBehaviour
{
    public static TowerCtrl instance;
    
    [SerializeField] public QueueOfEnemy _queueOfEnemy;

    [SerializeField] public TowerShooting _towerShooting;

    [SerializeField] public TowerUpdate _TowerUpdate;

    private void Awake()
    {
        _queueOfEnemy = GetComponent<QueueOfEnemy>();
        _towerShooting = GetComponent<TowerShooting>();
        _TowerUpdate = GetComponent<TowerUpdate>();
        instance = this;
    }
}
