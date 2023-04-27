using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float maxSpeed; // The maximum speed of the cars
    public float speedIncrement; // The amount to increase the speed by
    public float speedDecrement; // The amount to decrease the speed by

    public GameObject StartPannel;
    public GameObject Day;
    public GameObject Night;
  
    public Button startButtonDay; // The button to start the cars moving
    public Button startButtonNight; // The button to start the cars moving

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
        Time.timeScale = 0;
        // Find all the CarController components in the scene and add them to the cars array
        cars = FindObjectsOfType<CarController>();

        // Add a click listener to the start button to start the cars moving
        startButtonDay.onClick.AddListener(DayStartCars);
        startButtonNight.onClick.AddListener(NightStartCars);

        StartPannel.SetActive(true);
        Day.SetActive(true);
        Night.SetActive(false);
    }

    void Update()
    {
       
        // Update the speed of each car based on the public speed variables
        cars[0].speed = car1Speed;
        cars[1].speed = car2Speed;
        cars[2].speed = car3Speed;
        cars[3].speed = car4Speed;
        cars[4].speed = car5Speed;


      

       
    }

    // Method to start all the cars moving
   public void DayStartCars()
    {


        Time.timeScale = 1;
        Day.SetActive(true);
        Night.SetActive(false);
        StartPannel.SetActive(false);
  
        foreach (CarController car in cars)
        {
            car.StartMoving();
        }
    }

    public void NightStartCars()
    {

        Time.timeScale = 1;
        Day.SetActive(false);
        Night.SetActive(true);
        StartPannel.SetActive(false);
       
        foreach (CarController car in cars)
        {
            car.StartMoving();
        }
    }
    public void Stop()
    {
        Time.timeScale = 0;
        StartPannel.SetActive(true);
       
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
