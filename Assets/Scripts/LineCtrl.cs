using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineCtrl : MonoBehaviour
{
    public LineRenderer _lineRenderer;

    [SerializeField] private Texture[] _textures;

    private int animationStep;

    [SerializeField] private float fps = 30f;

    private float fpsCounter;

    private Transform target;

    private void Awake()
    {
        _lineRenderer = GetComponent<LineRenderer>();
    }

    public void AssignTarget(Vector3 startPos, Transform newTarget)
    {
        _lineRenderer.positionCount = 2;
        _lineRenderer.SetPosition(0,startPos);
        target = newTarget;
    }

    private void Update()
    {
        if (!target) return;
        _lineRenderer.SetPosition(1,target.position);
        fpsCounter += Time.deltaTime;
        if (fpsCounter >= 1f / fps)
        {
            animationStep++;
            if (animationStep == _textures.Length) animationStep = 0;
            _lineRenderer.material.SetTexture("_MainTex", _textures[animationStep]);
            fpsCounter = 0f;
        }
    }

    public void LineDespawn()
    {
        Destroy(gameObject);
    }
}
