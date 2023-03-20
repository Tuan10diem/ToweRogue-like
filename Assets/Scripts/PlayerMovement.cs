using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    protected Vector2 velocity = new Vector2(0f,0f);
    public float pressX = 0f;
    public float pressY = 0f;
    public float speed = 3f;
    protected Rigidbody2D rigid2D;
    private Vector2 PlayerPos = new Vector2(0,0);

    public bool DeadManDontMove = false;

    // Start is called before the first frame update
    void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (DeadManDontMove) return;
        pressX = Input.GetAxis("Horizontal");
        pressY = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        UpdatePosition();
        // LookAtTarget();
    }

    private void UpdatePosition()
    {
        velocity.x = pressX * speed;
        velocity.y = pressY * speed;
        rigid2D.MovePosition(this.rigid2D.position+velocity*Time.fixedDeltaTime);
    }

    private void LookAtTarget()
    {
        var mousePos = InputManager.instance.MouseWorldPos();
        var p = Camera.main.WorldToScreenPoint(transform.position);
        mousePos.x -= p.x;
        mousePos.y -= p.y;
        var angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(new Vector3(0f,0f,angle));
    }

    public Vector2 CurrentPosition()
    {
        PlayerPos = transform.position;
        return PlayerPos;
    }
}
