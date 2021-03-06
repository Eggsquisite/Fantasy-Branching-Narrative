﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform currentTarget;
    public float smoothTime = 0.3f;
    public Vector3 offset;

    private Vector3 velocity = Vector2.zero;

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, currentTarget.position + offset, ref velocity, smoothTime);
    }
}
