using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetPoints : SpawnPoint
{
    public static TargetPoints instance;

    protected override void Awake()
    {
        instance = this;
        base.Awake();
    }
    
}
