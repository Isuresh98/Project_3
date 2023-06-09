﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Parallax : MonoBehaviour
{
    public Camera mainCamera;
    public float parallaxSpeed;

    private float startPosX;
    private float length;

    void Start()
    {
        startPosX = transform.position.x;
        length = GetComponent<Tilemap>().size.x * GetComponent<Tilemap>().cellSize.x;
    }

    void Update()
    {
        float temp = (mainCamera.transform.position.x * (1 - parallaxSpeed));
        float dist = (mainCamera.transform.position.x * parallaxSpeed);

        transform.position = new Vector3(startPosX + dist, transform.position.y, transform.position.z);

        if (temp > startPosX + length)
        {
            startPosX += length;
        }
        else if (temp < startPosX - length)
        {
            startPosX -= length;
        }
    }
}
