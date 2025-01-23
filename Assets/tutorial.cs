using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tutorial : MonoBehaviour
{
  
   public GameObject pushSpaceTitle;
    void Start()
    {
        pushSpaceTitle = GameObject.FindGameObjectWithTag("tutorial");
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            pushSpaceTitle.SetActive(false);
        }
    }
}
