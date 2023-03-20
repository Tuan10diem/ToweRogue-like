using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class dmgTxt : MonoBehaviour
{

    [SerializeField] private TowerBase tb;
    [SerializeField] private TextMeshProUGUI txt;

    // Update is called once per frame
    void Update()
    {
        txt.text = tb.coinNeedToUpdateDmg.ToString();
    }
}
