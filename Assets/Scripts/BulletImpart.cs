using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletImpart: MonoBehaviour
{

    private CircleCollider2D _circleCollider2D;
    private Rigidbody2D _rigidbody2D;

    private BulletCtrl _bulletCtrl;
    
    // Start is called before the first frame update
    protected virtual void Awake()
    {
        _bulletCtrl = GetComponent<BulletCtrl>();
        LoadCollider();
        LoadRigidbody();
    }

    private void LoadCollider()
    {
        if (_circleCollider2D!=null) return;
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _circleCollider2D.isTrigger = true;
        _circleCollider2D.radius = 0.07f;
    }

    private void LoadRigidbody()
    {
        if (_rigidbody2D!=null) return;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 0;
    }

    protected virtual void OnTriggerEnter2D(Collider2D other)
    {
        _bulletCtrl._dameSender.Send(other.transform);
    }
}
