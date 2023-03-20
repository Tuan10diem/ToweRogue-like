using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerType : MonoBehaviour
{
    public List<GameObject> Types;

    private void Awake()
    {
        LoadTypes();
    }

    private void LoadTypes()
    {
        if (Types.Count > 0) return;
        foreach (GameObject p in transform)
        {
            Types.Add(p);
        }
    }

    public GameObject RandomTypes()
    {
        int tmp = Random.Range(0, Types.Count);
        return Types[tmp];
    }
}
