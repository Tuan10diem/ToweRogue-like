using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonCtrl : MonoBehaviour
{
    [SerializeField] private Button build;
    
    [SerializeField] private Button UpdateDmg;
    
    [SerializeField] private Button UpdateSD;

    [SerializeField] private TowerBase _towerBase;

    private void Awake()
    {
        _towerBase = GetComponent<TowerBase>();
    }

    private void Update()
    {
        if (_towerBase.isBuiltTower1)
        {
            build.gameObject.SetActive(false);
            if (TowerCtrl.instance._towerShooting.dmg < 35f)
            {
                UpdateDmg.gameObject.SetActive(true);
            }

            else UpdateDmg.gameObject.SetActive(false);
            if (TowerCtrl.instance._towerShooting.shootingDelay > 0.3f)
            {
                UpdateSD.gameObject.SetActive(true);
            }

            else UpdateSD.gameObject.SetActive(false);
        }
        else
        {
            build.gameObject.SetActive(true);
            UpdateDmg.gameObject.SetActive(false);
            UpdateSD.gameObject.SetActive(false);
        }
    }
}
