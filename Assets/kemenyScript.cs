using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kemenyScript : MonoBehaviour
{
    public float speed;
    public float deadzone = -19;
    public SpeedScript speeder;
    public ParticleSystem particle;

    // Start is called before the first frame update
    void Start()
    {
        speeder = GameObject.FindWithTag("Speeder").GetComponent<SpeedScript>();
        if (Random.Range(1, 5) == 1)
        {
            particle.Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        speed = speeder.getSpeed();
        transform.position += Vector3.left * speed * Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Destroy(gameObject);
        }
    }
}
