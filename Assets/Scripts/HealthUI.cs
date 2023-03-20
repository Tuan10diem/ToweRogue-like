using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class HealthUI : MonoBehaviour
{
    public UnityEngine.UI.Image img;
    
    // Update is called once per frame
    void Update()
    {
        float hp = PlayerCtrl.instance.playerDameReceiver.HP;
        img.fillAmount = hp/100;
    }
}
