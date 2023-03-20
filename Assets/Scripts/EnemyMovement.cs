using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Burst;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemyMovement : MonoBehaviour
{

    public float speed;
    // public float maxRotate;
    public float minDistanceFromPlayer;

    public float maxDistanceFromPlayer;
    
    private Vector3 target;
    public virtual void Update()
    {
        // LookAtTarget();
        if (!isMoving()) return;
        GetMoveDirection();
    }

    protected virtual void Move()
    {
        gameObject.transform.position =
            Vector3.MoveTowards(gameObject.transform.position, target, this.speed * Time.deltaTime);
    }

    protected virtual void GetMoveDirection()
    {
        Vector3 distance = PlayerCtrl.instance.transform.position - transform.position;
        if (distance.magnitude > minDistanceFromPlayer)
        {
            target = PlayerCtrl.instance.transform.position - distance.normalized * this.minDistanceFromPlayer;
            Move();
        }
    }
    
    // protected virtual void LookAtTarget()
    // {
    //     var offset = 0f;
    //     Vector2 direction = PlayerCtrl.instance.transform.position - transform.position;
    //     direction.Normalize();
    //     float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;       
    //     transform.rotation = Quaternion.Euler(Vector3.forward * (angle + offset));
    // }

    bool isMoving()
    {
        Vector3 distance = PlayerCtrl.instance.transform.position - transform.position;
        return distance.magnitude <= maxDistanceFromPlayer;
    }
}
