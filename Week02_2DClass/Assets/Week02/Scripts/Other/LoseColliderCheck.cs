using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseColliderCheck : MonoBehaviour
{
    //public int endGameSceneNumber = 1;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.name == "Ball")
        {

            //Debug.Log("GameObject1 triggered with " + col.name);
            GameManager.playerTurns = GameManager.playerTurns - 1;
            //Debug.Log("Player Turns" + GameManager.playerTurns);


            if (col.GetComponent<BallController>() != null)
            {
                col.GetComponent<BallController>().gameStarted = false;
            }
            //SceneManager.LoadScene(endGameSceneNumber);
        }
    }
}
