using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{

    // public BulletImpart _bulletImpart;
    public DameSender _dameSender;
    
    // Start is called before the first frame update
    void Awake()
    {
        // _bulletImpart = GetComponent<BulletImpart>();
        _dameSender = GetComponent<DameSender>();
    }
}
