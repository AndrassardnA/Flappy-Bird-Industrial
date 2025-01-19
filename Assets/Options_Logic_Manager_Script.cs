using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options_Logic_Manager_Script : MonoBehaviour
{
    public GameObject konnyu;
    public GameObject normal; 
    public GameObject nehez;
    public int nehezseg = 2;
    private GameObject[] nehezsegArr = new GameObject[3];

   void Start()
    {
      /*  konnyu = GameObject.FindWithTag("konnyu");
        normal = GameObject.FindWithTag("normal");
        nehez = GameObject.FindWithTag("nehez");*/
        nehezsegArr[0] = konnyu;
        nehezsegArr[1] = normal;
        nehezsegArr[2] = nehez;
        nehezsegArr[nehezseg-1].SetActive(true);
        if (nehezseg == 1)
        {
            nehezsegArr[2].SetActive(false);
            nehezsegArr[1].SetActive(false);
        }
        else if (nehezseg == 3)
        {
            nehezsegArr[0].SetActive(false);
            nehezsegArr[1].SetActive(false);
        }
        else
        {
            nehezsegArr[0].SetActive(false);
            nehezsegArr[2].SetActive(false);
        }
    }

    public void loadMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public int getNehezseg()
    {
        return nehezseg;
    }

    public void nehezsegNovel() {
        if (nehezseg < 3)
        {
            nehezseg++;
            if (nehezseg == 2)
            {
                nehezsegArr[0].SetActive(false);
                nehezsegArr[1].SetActive(true);
            }
            else
            {
                nehezsegArr[1].SetActive(false);
                nehezsegArr[2].SetActive(true);
            }
        }
        else
        {
            nehezseg = 1;
            nehezsegArr[2].SetActive(false);
            nehezsegArr[0].SetActive(true);
        }
    }
    public void nehezsegCsokkent() {
        if (nehezseg > 1)
        {
            nehezseg--;
            if (nehezseg == 2)
            {
                nehezsegArr[2].SetActive(false);
                nehezsegArr[1].SetActive(true);
            }
            else
            {
                nehezsegArr[1].SetActive(false);
                nehezsegArr[0].SetActive(true);
            }
        }
        else
        {
            nehezseg = 3;
            nehezsegArr[0].SetActive(false);
            nehezsegArr[2].SetActive(true);
        }
    }

}
