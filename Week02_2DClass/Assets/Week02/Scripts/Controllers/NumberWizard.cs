using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    // Variable for the code
    public int maxNumber = 1000;
    public int minNumber = 1;
    int guess = 500;

    public TextMeshProUGUI mainText;
    public TextMeshProUGUI guessText;

    public LoadScene lowerSceneObject;

    // int myScopeVarable = 7000;

    // Start is called before the first frame update
    void Start()
    {
        StarGame();
        NextGuess();
    }

    void StarGame()
    {

        string mainGameText = "Pick a number between " + maxNumber + " and " + minNumber + " so I can guess it!";
        mainText.SetText(mainGameText);

        /*
        Debug.Log("Welcome to Number Wizard");
        Debug.Log("The best game ever!");
        Debug.Log("In your mind pick a nubmer and done tell me what it is.");
        Debug.Log("The higest number you can pick is: " + maxNumber);
        Debug.Log("The lowest number you can pick is: " + minNumber);
        Debug.Log("Tell me if your number is higher or lower than: " + guess);
        Debug.Log("Push Up = higher, Push Down = lower, Push Enter = Correct");
        */
    }


    // Update is called once per frame
    void Update()
    {
        
        /*
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
        */
    }

    public void NumberIsHigher()
    {
        //Debug.Log("Guessing a new number");
        minNumber = guess;
        NextGuess();
    }

    public void NumberIsLower() 
    {

        //Debug.Log("Guessing a new number");
        maxNumber = guess;
        NextGuess();
    }

    public void NumberIsCorrect()
    {

        //Debug.Log("I guessed the number, I am a genius!");
        lowerSceneObject.GoToEndScene();
    }


    void NextGuess()
    {
        //guess = (maxNumber + minNumber) / 2;
        guess = Random.Range(minNumber, maxNumber);
        guessText.SetText(guess.ToString());
        //Debug.Log("Is it higer or lower than... " + guess);

    }
}
