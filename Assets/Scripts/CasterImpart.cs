using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasterImpart : BulletImpart
{
    private EnemyDameSender _dameSender;
    protected override void Awake()
    {
        _dameSender = GetComponent<EnemyDameSender>();
    }

    protected override void OnTriggerEnter2D(Collider2D other)
    {
        _dameSender.Send(other.transform);
    }
}
