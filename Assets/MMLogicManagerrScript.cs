using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MMLogicManagerrScript : MonoBehaviour
{
    
    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
    }
    public void OptionScreen()
    {
        SceneManager.LoadScene(2);
    }

}
