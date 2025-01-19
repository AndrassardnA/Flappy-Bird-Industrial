using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public float rotateDown=1;
    public float rotateUp = 1;
    private float speedUp = 3;
    public LogicScript logic;
    private bool birdIsAlive = true;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)&&birdIsAlive)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
            
            myRigidbody.rotation += rotateUp;
            
            
            speedUp = 3;
        }
        if (myRigidbody.rotation > 12)
        {
            rotateUp = 7;
        }
        else if(myRigidbody.rotation < -12)
        {
            rotateUp = 11;
        }
        else
        {
            rotateUp = 9;
        }
        if (speedUp < 500)
        {
            myRigidbody.rotation -= Time.deltaTime * speedUp; ;
            speedUp += Time.deltaTime * rotateDown;
        }
        if (myRigidbody.rotation > 45 && birdIsAlive)
        {
            myRigidbody.rotation = 45;
        }
        if (myRigidbody.rotation < -45 && birdIsAlive)
        {
            myRigidbody.rotation = -45;
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
