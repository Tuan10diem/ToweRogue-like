using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeImpart : MonoBehaviour
{
    private PolygonCollider2D _circleCollider2D;
    private Rigidbody2D _rigidbody2D;

    private EnemyDameSender _meleeAttacking;
    
    // Start is called before the first frame update
    private void Awake()
    {
        _meleeAttacking = GetComponent<EnemyDameSender>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        _meleeAttacking.Send(other.transform);
    }
}
