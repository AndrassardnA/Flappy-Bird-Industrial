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
    public Animator animator;
    public float zuhanasSebesseg;
   /* private bool fly;
    private float timer;
    private bool ableToFall;*/
    
    void Start()
    {
        logic = GameObject.FindWithTag("Logic").GetComponent<LogicScript>();
        animator.SetBool("Fly", true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = myRigidbody.velocity;
       /* if (velocity.y < zuhanasSebesseg&&ableToFall)
        {
            animator.SetBool("Fly", false);
            fly = false;
        }*/
        if (Input.GetKeyDown(KeyCode.Space)&&birdIsAlive)
        {
            /*animator.SetBool("Fly", true);*/
            /*timer = 0;
            ableToFall = false;
            fly = true;*/

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
    void LateUpdate()
    {
        /*if (birdIsAlive && fly)
        {
            timer += Time.deltaTime;
            if (timer >= 1.034f)
            {
                ableToFall = true;
                timer = 0;
            }
        }      */ 
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("Fly", false);
        logic.gameOver();
        birdIsAlive = false;
    }
}
