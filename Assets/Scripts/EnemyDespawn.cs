using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyDespawn : MonoBehaviour
{
    public EnemyCtrl enemyCtrl;

    public virtual void Despawn()
    {
        PlayerCtrl.instance.playerExp.Exp += Random.Range(1, 4);
        EnemySpawnerCtrl.instance.decreaseEnemy(1);
        Destroy(gameObject);
    }

    
}
