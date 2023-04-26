using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    private bool isMoving = false; // Whether the car is currently moving
    public float speed = 0f; // The speed of the car

    void Update()
    {
        // Move the car to the left based on its speed if it is currently moving
        if (isMoving)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
    }

    // Method to start the car moving
    public void StartMoving()
    {
        isMoving = true;
    }
}
