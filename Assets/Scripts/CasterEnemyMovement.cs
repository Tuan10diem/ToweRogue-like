using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class CasterEnemyMovement : EnemyMovement
{

    // public override void Update()
    // {
    //     base.Update();
    //     transform.position = new Vector3(transform.position.x, PlayerCtrl.instance.transform.position.y + 2, transform.position.z);
    //
    // }
    //
    // protected override void Move()
    // {
    //     float distance = Vector2.Distance(PlayerCtrl.instance.playerMovement.CurrentPosition(),transform.position);
    //     if (distance <= maxDistanceFromPlayer) return;
    //     transform.Translate(Vector3.right*speed*Time.deltaTime);
    // }
    //
    // protected override void GetMoveDirection()
    // {
    //     Vector3 playerPos = PlayerCtrl.instance.playerMovement.transform.position;
    //     Vector3 objPos = transform.position;
    //
    //     playerPos.x += Random.Range(-maxRotate, maxRotate);
    //     playerPos.z += Random.Range(-maxRotate, maxRotate);
    //
    //     Vector3 diff = playerPos - objPos;
    //     diff.Normalize();
    //     float rot_z = Mathf.Atan2(diff.y, diff.x) * Mathf.Rad2Deg;
    //     transform.rotation=Quaternion.Euler(0f,0f,rot_z);
    //     
    //     Debug.DrawLine(objPos,objPos+diff*7,Color.red, Mathf.Infinity);
    // }
}
