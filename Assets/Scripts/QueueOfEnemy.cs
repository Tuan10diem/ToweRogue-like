using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueueOfEnemy : MonoBehaviour
{
    public List<GameObject> Enemies = new List<GameObject>();
    public CircleCollider2D _circleCollider2D;
    
    public TowerCtrl _TowerCtrl;
    
    private void Awake()
    {
        GetComponent<CircleCollider2D>();
        _TowerCtrl = GetComponent<TowerCtrl>();
        _circleCollider2D.radius = 4.6f;
    }

    private void Update()
    {
        CheckEnemies();
    }

    private void CheckEnemies()
    {
        if (Enemies.Count == 0) return;
        // Debug.Log(Enemies[0].name);
        for (int i=Enemies.Count-1;i>=0;i--)
        {
            if (Enemies[i] == null) Enemies.RemoveAt(i);
        }
    }

    // private void CheckLine()
    // {
    //     if (Enemies.Count == 0) return;
    //     // Debug.Log(Enemies[0].name);
    //     foreach (var enemy in Enemies)
    //     {
    //         if (enemy == null)
    //         {
    //             Enemies.Remove(enemy);
    //         }
    //     }
    // }

    private void OnTriggerEnter2D(Collider2D col)
    {
        EnemyDameReceiver enemyDameReceiver = col.GetComponent<EnemyDameReceiver>();
        if (enemyDameReceiver==null) return;
        Enemies.Add(col.gameObject);
        col.gameObject.GetComponent<BombDespawn>().affectedTower.Add(this);
        Debug.Log("Add");
    }
    
    private void OnTriggerExit2D(Collider2D col)
    {
        EnemyDameReceiver enemyDameReceiver = col.GetComponent<EnemyDameReceiver>();
        if (enemyDameReceiver==null) return;
        if (enemyDameReceiver.isAttacked.Count!=0)
        {
            // _TowerCtrl._towerShooting.allLines.Remove(TowerCtrl.instance._towerShooting.newLine);
            // Destroy(_TowerCtrl._towerShooting.newLine.gameObject);
            // TowerCtrl.instance._towerShooting.newLine.gameObject.SetActive(false);
            // enemyDameReceiver.isAttacked.Clear();
            foreach (LineCtrl i in enemyDameReceiver.isAttacked)
            {
                i.LineDespawn();
            }
            enemyDameReceiver.isAttacked.Clear();
            // TowerCtrl.instance._towerShooting.newLine.LineDespawn();
            TowerCtrl.instance._towerShooting.allLines.Clear();
            // TowerCtrl.instance._towerShooting.newLine.gameObject.AddComponent<LineCtrl>();
        }
        Enemies.Remove(col.gameObject);
        Debug.Log("Remove");
    }
}
