using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerExp : MonoBehaviour
{
    public int Exp = 0;

    // Start is called before the first frame update
    void Start()
    {
        Exp = 0;
    }

    public int GetExp()
    {
        return Exp;
    }
}
