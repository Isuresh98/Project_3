﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxset : MonoBehaviour
{
    public Transform cam;
    public float relativeMove = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(cam.position.x * relativeMove, cam.position.y * relativeMove);
    }
}
