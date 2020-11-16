using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class StorySceneManager : MonoBehaviour
{
    public enum Choise { None, Option1, Option2, Option3 };

    public Choise choiceInStory;


    public void Option1() 
    {
        choiceInStory = Choise.Option1;
    }

    public void Option2() 
    {
        choiceInStory = Choise.Option2;
    }

    public void Option3() 
    {
        choiceInStory = Choise.Option3;
    }

    void TakePathInWood() 
    {
        switch (choiceInStory) 
        {
            case Choise.Option1:
                //SceneManager.LoadScene(ScneNumber);
                break;
            case Choise.Option2:
                //SceneManager.LoadScene(ScneNumber);
                break;
            case Choise.Option3:
                //SceneManager.LoadScene(ScneNumber);
                break;
        }
    }
}
