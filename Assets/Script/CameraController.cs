using UnityEngine;

public class CameraController : MonoBehaviour
{
    public CarController[] cars; // An array of CarController scripts for the cars to follow
    public float smoothTime = 0.5f; // The time it takes for the camera to smoothly follow the cars
    public Vector3 offset; // The offset of the camera from the cars

    private Vector3 velocity; // The current velocity of the camera

    void LateUpdate()
    {
        // Find the car with the maximum speed
        CarController maxSpeedCar = null;
        float maxSpeed = 0;
        foreach (CarController car in cars)
        {
            if (car.speed > maxSpeed)
            {
                maxSpeedCar = car;
                maxSpeed = car.speed;
            }
        }

        // If a car with maximum speed is found, move the camera towards it with a smooth dampening effect
        if (maxSpeedCar != null)
        {
            Vector3 targetPosition = new Vector3(maxSpeedCar.transform.position.x + offset.x, transform.position.y, transform.position.z);


            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}
