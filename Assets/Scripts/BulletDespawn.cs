using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BulletDespawn : MonoBehaviour
{

    [SerializeField] protected float despawnDistance = 30f;

    // Update is called once per frame
    void Update()
    {
        distanceUpdate();
    }

    private void distanceUpdate()
    {
        float distance = Vector2.Distance(PlayerCtrl.instance.playerMovement.CurrentPosition(), transform.position);
        if (distance < despawnDistance) return;
        Despawn();
    }

    public void Despawn()
    {
        Destroy(gameObject);
    }
}
