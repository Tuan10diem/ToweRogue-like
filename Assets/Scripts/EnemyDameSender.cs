using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDameSender : DameSender
{
    public override void Send(Transform other)
    {
        PlayerDameReceiver dameReceiver = other.GetComponent<PlayerDameReceiver>();
        if (dameReceiver==null) return;
        Send(dameReceiver);
    }
    
}
