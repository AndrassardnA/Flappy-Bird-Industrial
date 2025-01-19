using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnerBehav : MonoBehaviour
{
    public GameObject pipe1;
    public GameObject pipe2;
    public GameObject pipe3;
    public float spawnrate=4;
    private float timer = 0;
    public float heightOffsetmin = -2.7f;
    public float heightOffsetmax = 11.3f;
    public int r = 3;
    public SpeedScript speeder;
    public Options_Logic_Manager_Script opScript;
    private int nehezseg=2;
    // Start is called before the first frame update
    void Start()
    {
        nehezseg = 2;
        if (GameObject.FindWithTag("optionsLogic") != null)
        {
            opScript = GameObject.FindWithTag("optionsLogic").GetComponent<Options_Logic_Manager_Script>();
        }
        else
        {
            Debug.LogWarning("Az options még nem lett megnyitva");
        }
        
        spawnPipe(Random.Range(1, 4));
        speeder = GameObject.FindWithTag("Speeder").GetComponent<SpeedScript>();
        if (opScript != null)
        {
            nehezseg = opScript.getNehezseg();
        }
    }

    // Update is called once per frame
    void Update()
    {
        float spwnMin;
        float spwnMax;
        if (nehezseg == 1)
        {
            spwnMin = 3.5f;
            spwnMax = 7;
            
            
        }
        else if(nehezseg == 2)
        {
            spwnMin = 2.5f;
            spwnMax = 6;
            
        }
        else
        {
            spwnMin = 2;
            spwnMax = 4;
           
        }
         r = Random.Range(1, 4);
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe(r);
            timer = 0;
            spawnrate = Random.Range(spwnMin/(speeder.getSpeed()/3), spwnMax / (speeder.getSpeed() / 3));
        }
    }
    void spawnPipe(int r)
    {
        
        float maxHeight = transform.position.y - heightOffsetmax;
        float minHeight = transform.position.y + heightOffsetmin;
        switch (r)
        {
            case 1:
                Instantiate(pipe1,new Vector3(transform.position.x,Random.Range(minHeight,maxHeight),0), transform.rotation);
                //Instantiate(pipe1, new Vector3(transform.position.x, maxHeight, 0), transform.rotation);
                break;
            case 2:
                Instantiate(pipe2,new Vector3(transform.position.x,Random.Range(minHeight,maxHeight),0), transform.rotation);
                //Instantiate(pipe2, new Vector3(transform.position.x, maxHeight, 0), transform.rotation);
                break;
            case 3:
                Instantiate(pipe3,new Vector3(transform.position.x,Random.Range(minHeight,maxHeight),0), transform.rotation);
                //Instantiate(pipe3, new Vector3(transform.position.x, minHeight, 0), transform.rotation);
                break;

        }
        
    }   
}
