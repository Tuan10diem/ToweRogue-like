using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class TowerBase : MonoBehaviour
{
    [SerializeField] private GameObject menu;

    public GameObject tower1Prefab;

    public bool isBuiltTower1 = false;
    // private bool isBuiltTower2 = false;

    public Vector3 SpawnPos;

    public int coinNeedToBuild = 20;
    public int coinNeedToUpdateDmg = 30;
    public int coinNeedToUpdateSD = 30;

    private void Awake()
    {
        SpawnPos = menu.transform.position;
        SpawnPos.y += 0.5f;
    }

    private void ActiveMenu(bool isActive)
    {
        menu.SetActive(isActive);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActiveMenu(true);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ActiveMenu(false);
        }
    }

    public void BuildTower1()
    {
        if (PlayerCtrl.instance.playerExp.Exp < coinNeedToBuild)
        {
            return;
        }

        PlayerCtrl.instance.playerExp.Exp -= coinNeedToBuild;
        coinNeedToBuild += 30;
        Debug.Log("tower 1");
        isBuiltTower1 = true;
        Instantiate(tower1Prefab, SpawnPos, transform.rotation);
    }

    public void UpdateTower1ShootingDelay()
    {
        if (PlayerCtrl.instance.playerExp.Exp < coinNeedToUpdateSD)
        {
            return;
        }

        PlayerCtrl.instance.playerExp.Exp -= coinNeedToUpdateSD;
        coinNeedToUpdateSD += 15;
        Debug.Log("Update SD");
        TowerCtrl.instance._TowerUpdate.UpdateShootingDelay();
    }

    public void UpdateTower1Dmg()
    {
        if (PlayerCtrl.instance.playerExp.Exp < coinNeedToUpdateDmg)
        {
            return;
        }

        PlayerCtrl.instance.playerExp.Exp -= coinNeedToUpdateDmg;
        coinNeedToUpdateDmg += 15;
        
        Debug.Log("Update Dmg");
        TowerCtrl.instance._TowerUpdate.UpdateDmg();
    }
}

