using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{

    public EnemyDameReceiver _enemyDameReceiver;
    public EnemyDespawn _enemyDespawn;

    // Start is called before the first frame update
    void Awake()
    {
        _enemyDespawn = GetComponent<EnemyDespawn>();
        _enemyDameReceiver = GetComponent<EnemyDameReceiver>();
    }

}
