using System;
using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Vector3 newPos;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        PlayerCtrl playerCtrl = other.transform.GetComponent<PlayerCtrl>();
        if (playerCtrl == null) return;
        PlayerCtrl.instance.transform.position = newPos;
    }
}
