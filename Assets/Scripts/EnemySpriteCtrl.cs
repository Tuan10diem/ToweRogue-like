using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySpriteCtrl : MonoBehaviour
{

    private bool isRight = true;
    
    // Update is called once per frame
    void Update()
    {
        if (PlayerCtrl.instance.transform.position.x < transform.position.x && isRight)
        {
            GetComponent<SpriteRenderer>().flipX = true;
            isRight = false;
        }
        else if (PlayerCtrl.instance.transform.position.x > transform.position.x && !isRight)
        {
            GetComponent<SpriteRenderer>().flipX = false;
            isRight = true;
        }
    }
}
