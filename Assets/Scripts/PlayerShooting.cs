using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{

    [SerializeField] public GameObject bulletPrefab;

    public float shootingDelay = 0.1f;

    public float currentTime = 0f;

    public void FixedUpdate()
    {
        Shooting();
    }
    
    public virtual void Shooting()
    {
        if (!IsShooting())
        {
            // currentTime = 0;
            return;
        }

        currentTime += Time.fixedDeltaTime;
        if (currentTime < shootingDelay) return;
        currentTime = 0;
        
        
        var mousePos = InputManager.instance.MouseWorldPos();
        var p = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x -= p.x;
        mousePos.y -= p.y;
        var angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        // transform.rotation = Quaternion.Euler(new Vector3(0f,0f,angle));
        var offset = 0f;
        // var mousePos = InputManager.instance.MouseWorldPos();
        // Vector2 direction = mousePos - transform.position;
        // direction.Normalize();
        // float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;       
        Vector3 spawnPos = transform.position;
        // Quaternion rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
        Quaternion rotation =  Quaternion.Euler(Vector3.forward * (angle + offset));
        GameObject spawn = Instantiate(bulletPrefab, spawnPos, rotation);
        spawn.SetActive(true);
    }

    public virtual bool IsShooting() => InputManager.instance.OnFiring() == 1;
}
