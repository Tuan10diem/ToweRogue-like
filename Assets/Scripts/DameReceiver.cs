using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DameReceiver : MonoBehaviour
{
    public float HP;

    public List<LineCtrl> isAttacked = new List<LineCtrl>();

    public virtual void Receive(float dmg)
    {
        // Debug.Log("ua ua");
        HP -= dmg;
    }

    public bool IsDead()
    {
        return HP <= 0;
    }
}
