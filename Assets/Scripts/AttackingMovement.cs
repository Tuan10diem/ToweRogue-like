using System;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class AttackingMovement : MonoBehaviour
{
    public Vector3 direction;
    public Rigidbody2D _rigidbody2D;
    public float speed = 1f;

    private void Awake()
    {
        _rigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Movement();
        // OnTriggerEnter2D();
    }

    private void Movement()
    {
        Vector3 tmpVec = direction * Time.deltaTime * speed;
        this._rigidbody2D.MovePosition(transform.position+tmpVec);
    }

    public void OnTriggerEnter2D(Collider2D col)
    {
        NextTarget target = col.GetComponent<NextTarget>();
        if (target == null) return;
        string name = col.name;
        string tmp="";
        for (int i = 0; i < name.Length; i++)
        {
            if (name[i] == ' ') break;
            tmp += name[i];
        }
        if (tmp == "RandomUD")
        {
            int rand = Random.Range(0, 2);
            if (rand == 0) tmp = "Up";
            else tmp = "Down";
        }
        if (tmp == "Up") direction = new Vector3(0, 1, 0);
        else if (tmp == "Down") direction = new Vector3(0, -1, 0);
        else if (tmp == "Left") direction = new Vector3(-1, 0, 0);
        else direction = new Vector3(1, 0, 0);
    }
}
