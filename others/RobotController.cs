using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotController : MonoBehaviour
{
    public GameObject ballPrefab;
    public float interval;
    public Vector2 minAngle;
    public Vector2 maxAngle;
    [Range(0.2f, 0.8f)]
    public float minForce = 0.2f;
    [Range(0.5f, 2f)]
    public float maxForce = 2f;


    private GameObject lastBallObj;
    private float lastBall;
    private Ball ball;

    // Start is called before the first frame update
    void Start()
    {
        lastBall = Time.time;
        ThrowBall();
    }

    // Update is called once per frame
    void Update()
    {
        if (ball.readyToDestroy && Time.time >= lastBall + interval)
            ThrowBall();
    }

    private void ThrowBall()
    {
        lastBall = Time.time;
        if(lastBallObj != null)
            Destroy(lastBallObj);
        lastBallObj = GameObject.Instantiate(ballPrefab);
        ball = lastBallObj.GetComponent<Ball>();
        lastBallObj.transform.position = transform.position;
        lastBallObj.transform.rotation = Quaternion.Euler(UnityEngine.Random.Range(-minAngle.y, -maxAngle.y), UnityEngine.Random.Range(minAngle.x + 180, maxAngle.x + 180), 0);
        lastBallObj.GetComponent<Rigidbody>().AddForce(lastBallObj.transform.forward * UnityEngine.Random.Range(minForce, maxForce));
    }
}
