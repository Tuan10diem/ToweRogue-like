using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Random = UnityEngine.Random;

public class SpawnPoint : MonoBehaviour
{
    public List<Transform> points;

    protected virtual void Awake()
    {
        LoadPoints();
    }

    private void LoadPoints()
    {
        if (points.Count > 0) return;
        foreach (Transform p in transform)
        {
            points.Add(p);
        }
    }

    public Transform RandomPoint()
    {
        int tmp = Random.Range(0, points.Count);
        return points[tmp];
    }
    
}
