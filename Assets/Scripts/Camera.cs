﻿using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Camera : MonoBehaviour
{
    private float speed = 2.0F;

    private Transform target;

    private void Awake()
    {
        if (!target) target = FindObjectOfType<CharacterDizzy>().transform;
    }

    private void Update()
    {
        Vector3 position = target.position;
        position.z = -10.0F;
        transform.position = Vector3.Lerp(transform.position, position, speed * Time.deltaTime);
    }
}
