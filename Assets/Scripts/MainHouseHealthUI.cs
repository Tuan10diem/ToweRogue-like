using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHouseHealthUI : MonoBehaviour
{
    public MainHouseDameReceiver dmg;
    public UnityEngine.UI.Image img;

    private void Update()
    {
        float hp = dmg.HP;
        img.fillAmount = hp/100;
    }
}
