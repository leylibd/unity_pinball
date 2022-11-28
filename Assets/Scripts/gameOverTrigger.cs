using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameOverTrigger : MonoBehaviour
{
    public bool isDead = false;
    public GameObject ball;

    AudioSource ballKilled;


    private void OnTriggerEnter(Collider other)
    {
        GameObject loserBall = ball.GetComponent<ballSpawn>().newBall;
        Destroy(loserBall);
        isDead = true;
        Debug.Log("game over :(");
        ballKilled.Play();


        //kill ball
        //NOTE: im sure that this could have aslo be don in ballSpawn script without referencing. i just wanted to practice more in using references :)
    }

    // Start is called before the first frame update
    void Start()
    {
        ballKilled = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
