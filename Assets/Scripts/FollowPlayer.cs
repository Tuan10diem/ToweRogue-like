using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{

    public Transform target;
    public float speed = 2f;

    // Update is called once per frame
    void FixedUpdate()
    {
        Following();
    }

    private void Following()
    {
        if (target == null) return;
        transform.position = Vector3.Lerp(transform.position, target.position, speed * Time.fixedDeltaTime);
    }
}
