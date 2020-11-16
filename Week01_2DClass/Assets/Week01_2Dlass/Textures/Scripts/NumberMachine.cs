using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEditor.SceneManagement;
using UnityEngine;

public class NumberMachine : MonoBehaviour
{

    public int firstNumber = 2;
    public int secondNumber = 3;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Number Machine is Working");
        UnityEngine.Debug.Log("Number Machine is Woring");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            int addedNumber = AddNumbers(firstNumber, secondNumber);
            UnityEngine.Debug.Log("The Number " + firstNumber + " added to a sceond number " + secondNumber + " is equal to " + addedNumber);
        }
    }


    int AddNumbers(int first, int second) 
    {
        int returnNumber = 0;
        returnNumber = first + second;
        return returnNumber;
    }
}
