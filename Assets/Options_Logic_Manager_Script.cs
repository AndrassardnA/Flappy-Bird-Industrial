using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options_Logic_Manager_Script : MonoBehaviour
{
    public GameObject konnyu;
    public GameObject normal; 
    public GameObject nehez;
    public int nehezseg = 2;


    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void nehezsegNovel() {
        if (nehezseg < 3)
        {
            nehezseg++;
            if (nehezseg == 2)
            {
                konnyu.SetActive(false);
                normal.SetActive(true);
            }
            else
            {
                normal.SetActive(false);
                nehez.SetActive(true);
            }
        }
        else
        {
            nehezseg = 1;
            nehez.SetActive(false);
            konnyu.SetActive(true);
        }
    }
    public void nehezsegCsokkent() {
        if (nehezseg > 1)
        {
            nehezseg--;
            if (nehezseg == 2)
            {
                nehez.SetActive(false);
                normal.SetActive(true);
            }
            else
            {
                normal.SetActive(false);
                konnyu.SetActive(true);
            }
        }
        else
        {
            nehezseg = 3;
            konnyu.SetActive(false);
            nehez.SetActive(true);
        }
    }

}
