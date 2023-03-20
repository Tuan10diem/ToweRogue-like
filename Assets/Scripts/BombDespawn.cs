using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BombDespawn : EnemyDespawn
{
    public List<QueueOfEnemy> affectedTower;
    
    public override void Despawn()
    {
        AttackerSpawnerCtrl.instance.decreaseEnemy(1);
        if (enemyCtrl._enemyDameReceiver.isAttacked.Count!=0 && TowerCtrl.instance._towerShooting.newLine!=null)
        {
            
            // Destroy(TowerCtrl.instance._towerShooting.newLine.gameObject);
            // TowerCtrl.instance._towerShooting.newLine.gameObject.SetActive(false);
            foreach (LineCtrl i in enemyCtrl._enemyDameReceiver.isAttacked)
            {
                i.LineDespawn();
            }
            enemyCtrl._enemyDameReceiver.isAttacked.Clear();
            // TowerCtrl.instance._towerShooting.newLine.LineDespawn();
            TowerCtrl.instance._towerShooting.allLines.Clear();
            // TowerCtrl.instance._towerShooting.newLine.gameObject.AddComponent<LineCtrl>();
        }
        RemoveSelfFromTowerQueue();
        if(!gameObject.IsDestroyed()) Destroy(gameObject);
    }
    
    private void RemoveSelfFromTowerQueue()
    {
        affectedTower.ForEach(tower =>
        {
            if (tower.Enemies.Contains(gameObject))
            {
                tower.Enemies.Remove(gameObject);
            }
        });
    }
}
