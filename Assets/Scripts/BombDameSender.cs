using System;
using System.Collections;
using System.Collections.Generic;
using Newtonsoft.Json.Serialization;
using UnityEngine;

public class BombDameSender : EnemyDameSender
{
    private BombDespawn _bombDespawn;

    private void Awake()
    {
        _bombDespawn = GetComponent<BombDespawn>();
    }

    public override void Send(Transform other)
    {
        MainHouseDameReceiver dameReceiver = other.GetComponent<MainHouseDameReceiver>();
        if (dameReceiver == null) return;
        Send(dameReceiver);
        _bombDespawn.Despawn();
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        Send(col.transform);
    }
}
