using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Lay vi tri cua chuot
public class InputManager : MonoBehaviour
{
    static public InputManager instance;

    [SerializeField]
    protected Vector3 MousePos;

    public Vector3 MouseWorldPos()
    {
        return MousePos;
    }

    [SerializeField]
    private float onFiring;
    public float OnFiring()
    {
        return onFiring;
    }
    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
        GetMouseDown();
        // GetMousePos();
    }

    private void FixedUpdate()
    {
        GetMousePos();
    }

    public void GetMouseDown()
    {
        this.onFiring = Input.GetAxis("Fire1");
    }

    public void GetMousePos()
    {
        this.MousePos = Input.mousePosition;
        MousePos.z = 0;
    }
}
