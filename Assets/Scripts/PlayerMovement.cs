using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    private bool started;
    [SerializeField] float speed = 2f;
    bool gameOver;
    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }
    void Start()
    {
        started = false;
        gameOver = false;
    }
    

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
                GameManager.instance.GameStart();
            }
        }
        if (!Physics.Raycast(transform.position, Vector3.down, 1f) && !gameOver)
        {
            gameOver = true;
            Camera.main.GetComponent<CameraFollow>().gameOver = true;
            rb.velocity = new Vector3(0, -500, 0);
            GameManager.instance.GameOver();
        }
        if(Input.GetMouseButtonDown(0) && !gameOver) { 
            SwitchToDirection();
        }
    }

    void SwitchToDirection()
    {
        if(rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if(rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }

        SoundManager.instance.ClickSound();
        GameManager.instance.IncreaseScore();
    }

    private void OnTriggerEnter(Collider collision)
    {
            Debug.Log("collided");
            GameManager.instance.IncreaseScore();
            Debug.Log(collision.gameObject.tag);

            //Destroy(collision.gameObject);
            if (collision.gameObject.tag == "Diamond")
            {
                // Destroy the child GameObject
                Destroy(collision.gameObject);
            }
    }
}
