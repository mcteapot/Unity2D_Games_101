using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayLearning : MonoBehaviour
{

    public string[] playerNames = new string[4];
    public int playerNumber = 1;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Array Script Workign");

        /*
        playerNames[0] = "Ivan";
        playerNames[1] = "Fincher";
        playerNames[2] = "Nina";
        playerNames[3] = "Yale";
        */
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {

            Debug.Log("Player " + playerNumber + " name is " + playerNames[playerNumber]);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Debug.Log("Key Down Working");
            for (int i = 0; i < playerNames.Length; i++) 
            {
                Debug.Log("Player Number " + i + " Name is " + playerNames[i]);
                // Debug.Log("Count " + i);
            }
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) 
        {
            // Debug.Log("Key Right Working");

            foreach (string name in playerNames) 
            {
                Debug.Log("Player name is " + name);
            }
        }
    }
}
