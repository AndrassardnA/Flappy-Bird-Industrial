using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LogicScript : MonoBehaviour 
{
    public int scoreInt;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject pushSpaceTitle;
    
    void Start()
    {
        pushSpaceTitle = GameObject.FindGameObjectWithTag("tutorial");
        
    }

    [ContextMenu("Increase Score")]
    public void addScore(int scoreToAdd)
    {
        scoreInt+=scoreToAdd;
        scoreText.text = scoreInt.ToString();
    }
    public void restartGame()
    {
        SceneManager.LoadScene("gameplay");
    }
    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        pushSpaceTitle.SetActive(false);
    }
    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    
}


