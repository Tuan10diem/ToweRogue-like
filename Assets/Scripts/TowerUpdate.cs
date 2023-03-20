using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpdate : MonoBehaviour
{
    
    public void UpdateShootingDelay()
    {
        TowerCtrl.instance._towerShooting.shootingDelay =
            Math.Max(0.3f, TowerCtrl.instance._towerShooting.shootingDelay - 0.15f);
    }

    public void UpdateDmg()
    {
        TowerCtrl.instance._towerShooting.dmg += 1f;
    }
}
