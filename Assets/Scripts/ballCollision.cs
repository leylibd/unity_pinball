using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballCollision : MonoBehaviour
{
    private int collisionScore = 0;
    public Color randomColor;
    //public float forceOfBall;

    // Start is called before the first frame update
    void Start()
    {
        //forceOfBall = gameObject.GetComponent<ballSpawn>().force;
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(collisionScore);
        //next: when dies, reduce score. if score==500, start particles  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "colorGiver")
        {
            //change the color of the ball
            //Debug.Log("collided with giver");

            randomColor = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F)); //random color generated 
            gameObject.GetComponent<Renderer>().material.color = randomColor; //color of the ball changed

            //forceOfBall += 50; //adding force to the ball on collision
            collisionScore ++;
        }

        if (collision.gameObject.tag == "colorReceiver")
        {
            //change color of the object 

            randomColor = new Color(Random.Range(0F, 1F), Random.Range(0, 1F), Random.Range(0, 1F)); //random color generated 
            collision.gameObject.GetComponent<Renderer>().material.color = randomColor; //color of the object changed
            collisionScore++;
        }
    }

    

}
