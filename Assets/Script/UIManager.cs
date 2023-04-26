using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public InputField car1Input; // The input field to set the speed of car 1
    public InputField car2Input; // The input field to set the speed of car 2
    public InputField car3Input; // The input field to set the speed of car 3
    public InputField car4Input; // The input field to set the speed of car 4
    public InputField car5Input; // The input field to set the speed of car 5

    public GameManager gameManager; // The GameManager script

    void OnEnable()
    {
        // Subscribe to the onValueChanged event of each InputField
        car1Input.onValueChanged.AddListener((string value) => OnCarSpeedChanged(value, 0));
        car2Input.onValueChanged.AddListener((string value) => OnCarSpeedChanged(value, 1));
        car3Input.onValueChanged.AddListener((string value) => OnCarSpeedChanged(value, 2));
        car4Input.onValueChanged.AddListener((string value) => OnCarSpeedChanged(value, 3));
        car5Input.onValueChanged.AddListener((string value) => OnCarSpeedChanged(value, 4));
    }

    void OnDisable()
    {
        // Unsubscribe from the onValueChanged event of each InputField
        car1Input.onValueChanged.RemoveListener((string value) => OnCarSpeedChanged(value, 0));
        car2Input.onValueChanged.RemoveListener((string value) => OnCarSpeedChanged(value, 1));
        car3Input.onValueChanged.RemoveListener((string value) => OnCarSpeedChanged(value, 2));
        car4Input.onValueChanged.RemoveListener((string value) => OnCarSpeedChanged(value, 3));
        car5Input.onValueChanged.RemoveListener((string value) => OnCarSpeedChanged(value, 4));
    }

    void OnCarSpeedChanged(string value, int index)
    {
        // Parse the input value to a float
        float speed = float.Parse(value);

        // Pass the speed value to the corresponding GameManager method
        switch (index)
        {
            case 0:
                gameManager.car1Speed = speed;
                break;
            case 1:
                gameManager.car2Speed = speed;
                break;
            case 2:
                gameManager.car3Speed = speed;
                break;
            case 3:
                gameManager.car4Speed = speed;
                break;
            case 4:
                gameManager.car5Speed = speed;
                break;
            default:
                break;
        }
    }
}
