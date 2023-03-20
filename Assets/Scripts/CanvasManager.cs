using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private WaveCtrl waveController;
    [SerializeField] private TextMeshProUGUI timerTxt;
    [SerializeField] private TextMeshProUGUI endTxt;
    [SerializeField] private Image warningImg;
    [SerializeField] private TextMeshProUGUI expTxt;
    [SerializeField] private TextMeshProUGUI Score;

    public static Action<bool> ShowWarningCallback;

    private void OnEnable()
    {
        ShowWarningCallback += ShowWarning;
    }

    private void OnDisable()
    {
        ShowWarningCallback -= ShowWarning;
    }

    private void Update()
    {
        timerTxt.text = ((int)waveController.Wave).ToString();
        string status = "Wave end in:";
        if (waveController.isSpawn == 0) status = "Next wave start in:";
        endTxt.text = status;
        expTxt.text = PlayerCtrl.instance.playerExp.GetExp().ToString();
        Score.text = WaveCtrl.Score.ToString();
    }

    public void ShowWarning(bool isActive)
    {
        warningImg.gameObject.SetActive(isActive);
    }
}
