using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance { get { return _instance; } }

    public static int playerTurns = 3;
    public static int totalPoints = 0;
    public static int topScore = 0;
    
    public int endGameSceneNumber = 1;


    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CheckTopScore();

        CheckIfGameOver();
    }

    private static void CheckTopScore()
    {
        if (totalPoints >= topScore)
        {
            topScore = totalPoints;
        }
    }

    private void CheckIfGameOver() 
    {
        //Debug.Log("CheckIfGameOver is Working!");
        if (playerTurns == 0) 
        {
            //Debug.Log("Lost turns, Game Over");
            ResetGame();
            SceneManager.LoadScene(endGameSceneNumber);
        }
    }

    private void ResetGame() 
    {
        playerTurns = 3;
        totalPoints = 0;
    }
}