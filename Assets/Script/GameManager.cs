using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float maxSpeed; // The maximum speed of the cars
    public float speedIncrement; // The amount to increase the speed by
    public float speedDecrement; // The amount to decrease the speed by

    public Text[] speedTexts; // An array of UI Text elements to display the speed of each car
    public Button startButton; // The button to start the cars moving

    public float car1Speed; // The speed of car 1
    public float car2Speed; // The speed of car 2
    public float car3Speed; // The speed of car 3
    public float car4Speed; // The speed of car 4
    public float car5Speed; // The speed of car 5

    public InputField car1Input; // The input field to set the speed of car 1
    public InputField car2Input; // The input field to set the speed of car 2
    public InputField car3Input; // The input field to set the speed of car 3
    public InputField car4Input; // The input field to set the speed of car 4
    public InputField car5Input; // The input field to set the speed of car 5



    private CarController[] cars; // An array of CarController components for each car

    void Start()
    {
        // Find all the CarController components in the scene and add them to the cars array
        cars = FindObjectsOfType<CarController>();

        // Add a click listener to the start button to start the cars moving
        startButton.onClick.AddListener(StartCars);

        // Attach a script to each input field to set the speed of the corresponding car
        car1Input.onValueChanged.AddListener(delegate { SetCar1Speed(float.Parse(car1Input.text)); });
        car2Input.onValueChanged.AddListener(delegate { SetCar2Speed(float.Parse(car2Input.text)); });
        car3Input.onValueChanged.AddListener(delegate { SetCar3Speed(float.Parse(car3Input.text)); });
        car4Input.onValueChanged.AddListener(delegate { SetCar4Speed(float.Parse(car4Input.text)); });
        car5Input.onValueChanged.AddListener(delegate { SetCar5Speed(float.Parse(car5Input.text)); });
    }

    void Update()
    {
       
        // Update the speed of each car based on the public speed variables
        cars[0].speed = car1Speed;
        cars[1].speed = car2Speed;
        cars[2].speed = car3Speed;
        cars[3].speed = car4Speed;
        cars[4].speed = car5Speed;


        // Attach a script to each input field to set the speed of the corresponding car
        car1Input.onValueChanged.AddListener(delegate { SetCar1Speed(float.Parse(car1Input.text)); });
        car2Input.onValueChanged.AddListener(delegate { SetCar2Speed(float.Parse(car2Input.text)); });
        car3Input.onValueChanged.AddListener(delegate { SetCar3Speed(float.Parse(car3Input.text)); });
        car4Input.onValueChanged.AddListener(delegate { SetCar4Speed(float.Parse(car4Input.text)); });
        car5Input.onValueChanged.AddListener(delegate { SetCar5Speed(float.Parse(car5Input.text)); });


        // Update the UI to display the speed of each car
        for (int i = 0; i < speedTexts.Length; i++)
        {
            // Get the speed of the current car and update the corresponding UI Text element
            float speed = cars[i].speed;
            string speedText = "Car " + (i + 1) + ": " + speed.ToString("0.0");
            speedTexts[i].text = speedText;
        }
    }

    // Method to start all the cars moving
   public void StartCars()
    {
        foreach (CarController car in cars)
        {
            car.StartMoving();
        }
    }

    public void SetCar1Speed(float speed)
    {
        cars[0].speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

    public void SetCar2Speed(float speed)
    {
        cars[1].speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

    public void SetCar3Speed(float speed)
    {
        cars[2].speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

    public void SetCar4Speed(float speed)
    {
        cars[3].speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

    public void SetCar5Speed(float speed)
    {
        cars[4].speed = Mathf.Clamp(speed, 0, maxSpeed);
    }

}
