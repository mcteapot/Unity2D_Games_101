using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadScene : MonoBehaviour
{

    public int MainSceneNumber = 1;
    public int EndSceneNumber = 2;
    public int MainMenuSceneNumber = 0;
    
    public void StartGame()
    {
        //UnityEngine.Debug.Log("Start Game is Working");
        SceneManager.LoadScene(MainSceneNumber);
    }

    public void GoToEndScene() 
    {
        SceneManager.LoadScene(EndSceneNumber);
    }

    public void GoToMainMenu() 
    {
        SceneManager.LoadScene(MainMenuSceneNumber);
    }

    public void QuitGame() 
    {
        Application.Quit();
    }

}
