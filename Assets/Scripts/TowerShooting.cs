using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TowerShooting : MonoBehaviour
{
    public TowerCtrl _TowerCtrl;

    public float shootingDelay = 1f;

    public float currentTime = 0f;
    
    public float dmg = 5;
    
    public List<LineCtrl> allLines;

    private QueueOfEnemy _queueOfEnemy;
    
    public LineCtrl newLine;
    
    public LineCtrl linePrefab;
    
    private void Awake()
    {
        _TowerCtrl = GetComponent<TowerCtrl>();

        allLines = new List<LineCtrl>();
        
    }

    private void Update()
    {
        if (!newLine || newLine.gameObject.IsDestroyed()) newLine=new LineCtrl();
        check();
        Shooting();
    }

    private void check()
    {
        for (int i=allLines.Count-1;i>=0;i--)
        {
            if (allLines[i] == null) allLines.RemoveAt(i);
        }
    }

    private void Shooting()
    {
        currentTime += Time.deltaTime;
        if (currentTime < shootingDelay) return;
        Debug.Log("shoot");
        currentTime = 0;

        if (_TowerCtrl._queueOfEnemy.Enemies.Count == 0) return;

        if (allLines.Count == 0)
        {
            Debug.Log("tao");
            Vector3 pos = new Vector3(transform.position.x, transform.position.y + 0.7f, transform.position.z);
            newLine = Instantiate(linePrefab);
            // newLine.transform.position = pos;
            newLine.AssignTarget(pos, _TowerCtrl._queueOfEnemy.Enemies[0].transform);
            allLines.Add(newLine);
            _TowerCtrl._queueOfEnemy.Enemies[0].GetComponent<EnemyDameReceiver>().isAttacked.Add(newLine);
        }
        Debug.Log("ban bo me no di");
        _TowerCtrl._queueOfEnemy.Enemies[0].GetComponent<EnemyDameReceiver>().Receive(dmg);
    }
}
