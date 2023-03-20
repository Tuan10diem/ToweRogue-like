using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MeleeEnemyMovement : EnemyMovement
{
    // private Vector3 target;
    // private void Update()
    // {
    //     GetMoveDirection();
    // }
    //
    // protected override void Move()
    // {
    //     gameObject.transform.position =
    //         Vector3.MoveTowards(gameObject.transform.position, target, this.speed * Time.deltaTime);
    // }
    //
    // protected override void GetMoveDirection()
    // {
    //     Vector3 distance = PlayerCtrl.instance.transform.position - transform.position;
    //     if (distance.magnitude > maxDistanceFromPlayer)
    //     {
    //         target = PlayerCtrl.instance.transform.position - distance.normalized * this.maxDistanceFromPlayer;
    //         Move();
    //     }
    // }
}
