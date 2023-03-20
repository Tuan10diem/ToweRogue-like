using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacking : PlayerShooting
{
    
    public float attackRange;
    
    public override bool IsShooting()
    {
        float dis = Vector2.Distance(transform.position, PlayerCtrl.instance.playerMovement.CurrentPosition());
        return dis <= attackRange;
    }

    public override void Shooting()
    {
        if (!IsShooting()) return;
        
        currentTime += Time.fixedDeltaTime;
        if (currentTime < shootingDelay) return;
        currentTime = 0;
        
        var offset = 0f;
        Vector2 direction = PlayerCtrl.instance.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;       
        Quaternion rotation =  Quaternion.Euler(Vector3.forward * (angle + offset));
        
        Vector3 spawnPos = transform.position;
        GameObject spawn = Instantiate(bulletPrefab, spawnPos, rotation);
        spawn.SetActive(true);
    }
    
}
