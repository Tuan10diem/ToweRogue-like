using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletFly : MonoBehaviour
{

    [SerializeField] protected int bulletSpeed = 20;
    [SerializeField] private Vector3 direction = new Vector3(1,0,0);

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*bulletSpeed*Time.deltaTime);
    }
}
