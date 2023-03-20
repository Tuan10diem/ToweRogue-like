using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public void OnTriggerEnter2D(Collider2D col)
    {
        BulletDespawn isBullet = col.GetComponent<BulletDespawn>();
        if (isBullet == null || isBullet.IsDestroyed()) return;
        isBullet.Despawn();
    }
}
