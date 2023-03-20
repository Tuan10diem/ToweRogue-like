using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IsBuilt : MonoBehaviour
{
    public TowerBase _TowerBase;

    void Update()
    {
        if (_TowerBase.isBuiltTower1) gameObject.SetActive(false);
    }
    
    
}
