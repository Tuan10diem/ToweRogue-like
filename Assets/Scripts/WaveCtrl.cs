using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class WaveCtrl : MonoBehaviour
{
    public static int Score=0;
    
    public float countDownTime = 60f;
    public float WaveTime = 60f;
    public float Wave = 40f;

    // public AttackerSpawner _attackerSpawner;
    public GameObject spawn;

    // public SpawnPoint spawn;
    public int isSpawn = 0;

    private bool hasShowedWarning = false;

    private void Awake()
    {
        Score = 0;
    }

    private void UpScore()
    {
        Score++;
    }

    // Update is called once per frame
    void Update()
    {
        Wave -= Time.deltaTime;
        
        if (Wave <= 0)
        {
            if (isSpawn == 1)
            {
                Wave = countDownTime;
            }
            else
            {
                Wave = WaveTime;
                UpScore();
            }
            isSpawn = 1 - isSpawn;
            WaveTime += 8f;
            countDownTime = Mathf.Max(countDownTime-5f,20f);
            AttackerSpawnerCtrl.instance._AttackerSpawner.delayTime -= 0.2f;
            AttackerSpawnerCtrl.instance._AttackerSpawner.delayTime = Mathf.Max(0.2f, AttackerSpawnerCtrl.instance._AttackerSpawner.delayTime);
        }

        if (hasShowedWarning)
        {
            CanvasManager.ShowWarningCallback?.Invoke(false);
            hasShowedWarning = false;
        }

        if (isSpawn == 1)
        {
            // _attackerSpawner.GameObject().SetActive(true);
            // this.GameObject().SetActive(true);

            spawn.SetActive(true);
            
        }
        else
        {
            // _attackerSpawner.GameObject().SetActive(false);
            // this.GameObject().SetActive(false);
            spawn.SetActive(false);
            if (Wave <= 3 && !hasShowedWarning)
            {
                CanvasManager.ShowWarningCallback?.Invoke(true);
                hasShowedWarning = true;
            }
        }
    }
}