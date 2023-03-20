using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsUpdateShootingDelay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(TowerCtrl.instance._towerShooting.shootingDelay <=0.3f) gameObject.SetActive(false);        
    }
}
