using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameSender : MonoBehaviour
{

    [SerializeField] protected float dmg = 1;

    public virtual void Send(Transform other)
    {
        EnemyDameReceiver dameReceiver = other.GetComponent<EnemyDameReceiver>();
        if (dameReceiver==null) return;
        Send(dameReceiver);
    }

    public void Send(DameReceiver dameReceiver)
    {
        dameReceiver.Receive(dmg);
        Destroy(gameObject);
    }
}
