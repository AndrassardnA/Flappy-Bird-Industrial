using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
    }

    // Update is called once per frame
    void Update()
    {
        if (speed < 10)
        {
            speed += 0.1f * Time.deltaTime*0.4f;
        }
        
    }
    public float getSpeed()
    {
        return speed;
    }
}
