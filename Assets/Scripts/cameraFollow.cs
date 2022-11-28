using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public GameObject ball;
    public Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        GameObject ballToFollow = ball.GetComponent<ballSpawn>().newBall;  //get ref of an instantiated ball
        target = ballToFollow.transform.position;
        transform.LookAt(target);
        //this gets an error that the connection to ref object is lost bc object is destroyed. but it still works after the destroy --------------toFix--------------
    }
}
