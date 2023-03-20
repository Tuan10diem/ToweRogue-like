using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyState : MonoBehaviour
{

    private EnemyCtrl _enemyCtrl;
    
    // Start is called before the first frame update
    void Awake()
    {
        _enemyCtrl = GetComponent<EnemyCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!_enemyCtrl) return;
        if(_enemyCtrl._enemyDameReceiver.IsDead())
        {
            // PlayerCtrl.instance.playerExp.Exp += Random.Range(1, 4);
            _enemyCtrl._enemyDespawn.Despawn();
        }
    }
}
