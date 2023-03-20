using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SDTxt : MonoBehaviour
{
    [SerializeField] private TowerBase tb;
    [SerializeField] private TextMeshProUGUI txt;

    // Update is called once per frame
    void Update()
    {
        txt.text = tb.coinNeedToUpdateSD.ToString();
    }
}
