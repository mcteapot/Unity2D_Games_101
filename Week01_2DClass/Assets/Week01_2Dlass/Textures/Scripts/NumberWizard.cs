using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    // Variable for the code
    int maxNumber = 1000;
    int minNumber = 1;
    int guess = 500;

    // int myScopeVarable = 7000;

    // Start is called before the first frame update
    void Start()
    {
        StarGame();
    }

    void StarGame() 
    {
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("The best game ever!");
        Debug.Log("In your mind pick a nubmer and done tell me what it is.");
        Debug.Log("The higest number you can pick is: " + maxNumber);
        Debug.Log("The lowest number you can pick is: " + minNumber);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
    }


    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Guessing a new number");
            minNumber = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Guessing a new number");
            maxNumber = guess;
            NextGuess();
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("I guessed the number, I am a genius!");
        }
        else 
        {
            // Debug.Log("Nothing is being pressed");
        }
    }

    void NextGuess()
    {
        guess = (maxNumber + minNumber) / 2;
        Debug.Log("Is it higer or lower than... " + guess);
    }
}
