using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform ball;
    public float lerpRate;
    public bool gameOver;
    public float lerpSpeed;
    Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset = ball.position - transform.position;
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameOver)
        {
            Follow();
        }
    }

    void Follow()
    {
        Vector3 tempPos = transform.position;
        Vector3 targetPos = ball.position - offset;
        tempPos = Vector3.Lerp(tempPos, targetPos, lerpRate * Time.deltaTime);
        transform.position = tempPos;

    }
}
